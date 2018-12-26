using FileEncoding;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MainFrm
{
    public partial class FrmMain : Form
    {
        /// <summary>
        /// 存放文件的全路径
        /// </summary>
        private List<String> _files = new List<string>();

        /// <summary>
        /// 文件文件路径
        /// </summary>
        private String _dir;

        private Boolean _isNewline = true;

        private String _splitStr;

        public FrmMain()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            EventBind();
            InitData();
        }

        /// <summary>
        /// 初始划数据
        /// </summary>
        private void InitData()
        {
            this.cbFilter.SelectedIndex = 0;
        }

        /// <summary>
        /// 绑定事件
        /// </summary>
        private void EventBind()
        {
            this.btnLoadFile.Click += BtnLoadFile_Click;
            this.btnExec.Click += BtnExec_Click;
        }
        /// <summary>
        /// 执行开始合并
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExec_Click(object sender, EventArgs e)
        {
            String desPath = Path.Combine(this._dir, "all.txt");
            foreach (var f in this._files)
            {
                ReadAndWriteFile(desPath, f, this._splitStr, this._isNewline);
            }
            WriteLog("写入完成");
            WriteLog("合并后的文件路径:" + desPath);
        }

        /// <summary>
        /// 加载文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLoadFile_Click(object sender, EventArgs e)
        {
            this.lbFiles.Items.Clear();
            _dir = this.txtDir.Text;
            if (String.IsNullOrEmpty(_dir))
            {
                MessageBox.Show("请先输入要合并文件对应的文件夹路径");
                this.txtDir.Focus();
                return;
            }
            this._isNewline = this.cbIsNewLine.Checked;
            this._splitStr = this.txtSplit.Text;
            String[] files = Directory.GetFiles(_dir, this.cbFilter.Text);
            _files.Clear();
            _files.AddRange(files);
            List<String> filesName = files.ToList().Select(f => Path.GetFileName(f)).ToList();
            filesName.ForEach(f => this.lbFiles.Items.Add(f));
            WriteLog("文件加载完成");
        }

        /// <summary>
        /// 读写文件
        /// </summary>
        /// <param name="desPath"></param>
        /// <param name="path"></param>
        /// <param name="splitStr"></param>
        /// <param name="isNewline"></param>
        private void ReadAndWriteFile(String desPath, String path, String splitStr, Boolean isNewline)
        {
            WriteLog("正在读取文件" + Path.GetFileName(path));
            Encoding encoding = EncodingType.GetType(path);
            String content = File.ReadAllText(path, encoding);
            StringBuilder sb = new StringBuilder();
            if (String.IsNullOrEmpty(splitStr)) splitStr = "";
            if (isNewline)
            {
                sb.AppendFormat("{0}{1}{0}", Environment.NewLine, splitStr);
            }
            sb.Insert(0, content);
            File.AppendAllText(desPath, sb.ToString(), Encoding.UTF8);
        }

        private void WriteLog(String msg)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}:{1}{2}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), msg, Environment.NewLine);
            this.txtLog.AppendText(sb.ToString());
        }
    }
}

