namespace MainFrm
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExec = new System.Windows.Forms.Button();
            this.cbIsNewLine = new System.Windows.Forms.CheckBox();
            this.txtSplit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbFiles);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 536);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件列表";
            // 
            // lbFiles
            // 
            this.lbFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.ItemHeight = 15;
            this.lbFiles.Location = new System.Drawing.Point(3, 21);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.ScrollAlwaysVisible = true;
            this.lbFiles.Size = new System.Drawing.Size(253, 512);
            this.lbFiles.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbFilter);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnExec);
            this.panel1.Controls.Add(this.cbIsNewLine);
            this.panel1.Controls.Add(this.txtSplit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLoadFile);
            this.panel1.Controls.Add(this.txtDir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(259, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 122);
            this.panel1.TabIndex = 3;
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(588, 60);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(92, 33);
            this.btnExec.TabIndex = 6;
            this.btnExec.Text = "开始合并";
            this.btnExec.UseVisualStyleBackColor = true;
            // 
            // cbIsNewLine
            // 
            this.cbIsNewLine.AutoSize = true;
            this.cbIsNewLine.Checked = true;
            this.cbIsNewLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIsNewLine.Location = new System.Drawing.Point(213, 60);
            this.cbIsNewLine.Name = "cbIsNewLine";
            this.cbIsNewLine.Size = new System.Drawing.Size(119, 19);
            this.cbIsNewLine.TabIndex = 5;
            this.cbIsNewLine.Text = "是否启用换行";
            this.cbIsNewLine.UseVisualStyleBackColor = true;
            // 
            // txtSplit
            // 
            this.txtSplit.Location = new System.Drawing.Point(89, 58);
            this.txtSplit.Name = "txtSplit";
            this.txtSplit.Size = new System.Drawing.Size(100, 25);
            this.txtSplit.TabIndex = 4;
            this.txtSplit.Text = "GO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "分割符：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "文件夹：";
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(588, 15);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(92, 33);
            this.btnLoadFile.TabIndex = 1;
            this.btnLoadFile.Text = "读取文件";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(91, 23);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(285, 25);
            this.txtDir.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLog);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(259, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 414);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输出日志";
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(3, 21);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(694, 390);
            this.txtLog.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "文件后缀：";
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "*.sql",
            "*.txt",
            "*.SQL",
            "*.TXT"});
            this.cbFilter.Location = new System.Drawing.Point(476, 28);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(75, 23);
            this.cbFilter.TabIndex = 8;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(959, 536);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "文本合并工具（作者QQ：751193963）";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.TextBox txtSplit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.CheckBox cbIsNewLine;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label3;
    }
}

