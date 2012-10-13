namespace FileDateCopy
{
    partial class FormMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPathSrc = new System.Windows.Forms.TextBox();
            this.textBoxPathDst = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxDirCTime = new System.Windows.Forms.CheckBox();
            this.checkBoxDirMTime = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxFileCTime = new System.Windows.Forms.CheckBox();
            this.checkBoxFileMTime = new System.Windows.Forms.CheckBox();
            this.checkBoxFileATime = new System.Windows.Forms.CheckBox();
            this.buttonBrowseDst = new System.Windows.Forms.Button();
            this.buttonBrowseSrc = new System.Windows.Forms.Button();
            this.listViewLog = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination Path:";
            // 
            // textBoxPathSrc
            // 
            this.textBoxPathSrc.Location = new System.Drawing.Point(100, 19);
            this.textBoxPathSrc.Name = "textBoxPathSrc";
            this.textBoxPathSrc.Size = new System.Drawing.Size(581, 20);
            this.textBoxPathSrc.TabIndex = 2;
            // 
            // textBoxPathDst
            // 
            this.textBoxPathDst.Location = new System.Drawing.Point(100, 45);
            this.textBoxPathDst.Name = "textBoxPathDst";
            this.textBoxPathDst.Size = new System.Drawing.Size(581, 20);
            this.textBoxPathDst.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.buttonBrowseDst);
            this.groupBox1.Controls.Add(this.buttonBrowseSrc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxPathDst);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxPathSrc);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 125);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxDirCTime);
            this.groupBox3.Controls.Add(this.checkBoxDirMTime);
            this.groupBox3.Location = new System.Drawing.Point(410, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 45);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dir";
            // 
            // checkBoxDirCTime
            // 
            this.checkBoxDirCTime.AutoSize = true;
            this.checkBoxDirCTime.Checked = true;
            this.checkBoxDirCTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDirCTime.Location = new System.Drawing.Point(8, 20);
            this.checkBoxDirCTime.Name = "checkBoxDirCTime";
            this.checkBoxDirCTime.Size = new System.Drawing.Size(91, 17);
            this.checkBoxDirCTime.TabIndex = 9;
            this.checkBoxDirCTime.Text = "Creation Time";
            this.checkBoxDirCTime.UseVisualStyleBackColor = true;
            // 
            // checkBoxDirMTime
            // 
            this.checkBoxDirMTime.AutoSize = true;
            this.checkBoxDirMTime.Checked = true;
            this.checkBoxDirMTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDirMTime.Location = new System.Drawing.Point(105, 20);
            this.checkBoxDirMTime.Name = "checkBoxDirMTime";
            this.checkBoxDirMTime.Size = new System.Drawing.Size(97, 17);
            this.checkBoxDirMTime.TabIndex = 10;
            this.checkBoxDirMTime.Text = "LastWrite Time";
            this.checkBoxDirMTime.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxFileCTime);
            this.groupBox2.Controls.Add(this.checkBoxFileMTime);
            this.groupBox2.Controls.Add(this.checkBoxFileATime);
            this.groupBox2.Location = new System.Drawing.Point(9, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 45);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File";
            // 
            // checkBoxFileCTime
            // 
            this.checkBoxFileCTime.AutoSize = true;
            this.checkBoxFileCTime.Checked = true;
            this.checkBoxFileCTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFileCTime.Location = new System.Drawing.Point(8, 20);
            this.checkBoxFileCTime.Name = "checkBoxFileCTime";
            this.checkBoxFileCTime.Size = new System.Drawing.Size(91, 17);
            this.checkBoxFileCTime.TabIndex = 6;
            this.checkBoxFileCTime.Text = "Creation Time";
            this.checkBoxFileCTime.UseVisualStyleBackColor = true;
            // 
            // checkBoxFileMTime
            // 
            this.checkBoxFileMTime.AutoSize = true;
            this.checkBoxFileMTime.Checked = true;
            this.checkBoxFileMTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFileMTime.Location = new System.Drawing.Point(105, 20);
            this.checkBoxFileMTime.Name = "checkBoxFileMTime";
            this.checkBoxFileMTime.Size = new System.Drawing.Size(97, 17);
            this.checkBoxFileMTime.TabIndex = 7;
            this.checkBoxFileMTime.Text = "LastWrite Time";
            this.checkBoxFileMTime.UseVisualStyleBackColor = true;
            // 
            // checkBoxFileATime
            // 
            this.checkBoxFileATime.AutoSize = true;
            this.checkBoxFileATime.Checked = true;
            this.checkBoxFileATime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFileATime.Location = new System.Drawing.Point(208, 20);
            this.checkBoxFileATime.Name = "checkBoxFileATime";
            this.checkBoxFileATime.Size = new System.Drawing.Size(107, 17);
            this.checkBoxFileATime.TabIndex = 8;
            this.checkBoxFileATime.Text = "LastAccess Time";
            this.checkBoxFileATime.UseVisualStyleBackColor = true;
            // 
            // buttonBrowseDst
            // 
            this.buttonBrowseDst.Location = new System.Drawing.Point(687, 43);
            this.buttonBrowseDst.Name = "buttonBrowseDst";
            this.buttonBrowseDst.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseDst.TabIndex = 4;
            this.buttonBrowseDst.Text = "Browse...";
            this.buttonBrowseDst.UseVisualStyleBackColor = true;
            this.buttonBrowseDst.Click += new System.EventHandler(this.buttonBrowseDst_Click);
            // 
            // buttonBrowseSrc
            // 
            this.buttonBrowseSrc.Location = new System.Drawing.Point(687, 17);
            this.buttonBrowseSrc.Name = "buttonBrowseSrc";
            this.buttonBrowseSrc.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseSrc.TabIndex = 3;
            this.buttonBrowseSrc.Text = "Browse...";
            this.buttonBrowseSrc.UseVisualStyleBackColor = true;
            this.buttonBrowseSrc.Click += new System.EventHandler(this.buttonBrowseSrc_Click);
            // 
            // listViewLog
            // 
            this.listViewLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewLog.FullRowSelect = true;
            this.listViewLog.Location = new System.Drawing.Point(12, 145);
            this.listViewLog.MultiSelect = false;
            this.listViewLog.Name = "listViewLog";
            this.listViewLog.Size = new System.Drawing.Size(768, 302);
            this.listViewLog.TabIndex = 4;
            this.listViewLog.UseCompatibleStateImageBehavior = false;
            this.listViewLog.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Source File";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Dest File";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Creation Time";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "LastWrite Time";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Access Time";
            this.columnHeader5.Width = 80;
            // 
            // buttonProcess
            // 
            this.buttonProcess.Location = new System.Drawing.Point(490, 478);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(75, 23);
            this.buttonProcess.TabIndex = 5;
            this.buttonProcess.Text = "&Process";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(653, 477);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 525);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.listViewLog);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "FileDateCopy";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPathSrc;
        private System.Windows.Forms.TextBox textBoxPathDst;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonBrowseSrc;
        private System.Windows.Forms.Button buttonBrowseDst;
        private System.Windows.Forms.CheckBox checkBoxDirMTime;
        private System.Windows.Forms.CheckBox checkBoxDirCTime;
        private System.Windows.Forms.CheckBox checkBoxFileATime;
        private System.Windows.Forms.CheckBox checkBoxFileMTime;
        private System.Windows.Forms.CheckBox checkBoxFileCTime;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewLog;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.Button buttonExit;
    }
}

