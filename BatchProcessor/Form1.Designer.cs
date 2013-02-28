namespace BatchProcessor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.cmdChooseDicDir = new System.Windows.Forms.Button();
            this.lblDicDir = new System.Windows.Forms.Label();
            this.cmdFile = new System.Windows.Forms.Button();
            this.lblFile = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmdStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDic1Count = new System.Windows.Forms.Label();
            this.lblDic2Count = new System.Windows.Forms.Label();
            this.cmdPause = new System.Windows.Forms.Button();
            this.cmdResume = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.cmdStop = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSleepTime = new System.Windows.Forms.TextBox();
            this.txtAfter = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmdList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdChooseDicDir
            // 
            this.cmdChooseDicDir.Location = new System.Drawing.Point(25, 17);
            this.cmdChooseDicDir.Name = "cmdChooseDicDir";
            this.cmdChooseDicDir.Size = new System.Drawing.Size(95, 23);
            this.cmdChooseDicDir.TabIndex = 0;
            this.cmdChooseDicDir.Text = "Dic. Directory";
            this.cmdChooseDicDir.UseVisualStyleBackColor = true;
            this.cmdChooseDicDir.Click += new System.EventHandler(this.cmdChooseDicDir_Click);
            // 
            // lblDicDir
            // 
            this.lblDicDir.AutoSize = true;
            this.lblDicDir.Location = new System.Drawing.Point(126, 17);
            this.lblDicDir.Name = "lblDicDir";
            this.lblDicDir.Size = new System.Drawing.Size(0, 13);
            this.lblDicDir.TabIndex = 1;
            // 
            // cmdFile
            // 
            this.cmdFile.Location = new System.Drawing.Point(25, 56);
            this.cmdFile.Name = "cmdFile";
            this.cmdFile.Size = new System.Drawing.Size(95, 23);
            this.cmdFile.TabIndex = 2;
            this.cmdFile.Text = "File";
            this.cmdFile.UseVisualStyleBackColor = true;
            this.cmdFile.Click += new System.EventHandler(this.cmdFile_Click);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(129, 56);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(0, 13);
            this.lblFile.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(25, 229);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(95, 23);
            this.cmdStart.TabIndex = 4;
            this.cmdStart.Text = "Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Count:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(82, 93);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 13);
            this.lblCount.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Word:";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(64, 106);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(0, 13);
            this.lblWord.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dic1 Count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dic2 Count:";
            // 
            // lblDic1Count
            // 
            this.lblDic1Count.AutoSize = true;
            this.lblDic1Count.Location = new System.Drawing.Point(95, 122);
            this.lblDic1Count.Name = "lblDic1Count";
            this.lblDic1Count.Size = new System.Drawing.Size(13, 13);
            this.lblDic1Count.TabIndex = 11;
            this.lblDic1Count.Text = "0";
            // 
            // lblDic2Count
            // 
            this.lblDic2Count.AutoSize = true;
            this.lblDic2Count.Location = new System.Drawing.Point(95, 136);
            this.lblDic2Count.Name = "lblDic2Count";
            this.lblDic2Count.Size = new System.Drawing.Size(13, 13);
            this.lblDic2Count.TabIndex = 12;
            this.lblDic2Count.Text = "0";
            // 
            // cmdPause
            // 
            this.cmdPause.Enabled = false;
            this.cmdPause.Location = new System.Drawing.Point(126, 229);
            this.cmdPause.Name = "cmdPause";
            this.cmdPause.Size = new System.Drawing.Size(95, 23);
            this.cmdPause.TabIndex = 13;
            this.cmdPause.Text = "Pause";
            this.cmdPause.UseVisualStyleBackColor = true;
            this.cmdPause.Click += new System.EventHandler(this.cmdPause_Click);
            // 
            // cmdResume
            // 
            this.cmdResume.Enabled = false;
            this.cmdResume.Location = new System.Drawing.Point(228, 229);
            this.cmdResume.Name = "cmdResume";
            this.cmdResume.Size = new System.Drawing.Size(75, 23);
            this.cmdResume.TabIndex = 14;
            this.cmdResume.Text = "Resume";
            this.cmdResume.UseVisualStyleBackColor = true;
            this.cmdResume.Click += new System.EventHandler(this.cmdResume_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Progress";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(95, 153);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(13, 13);
            this.lblProgress.TabIndex = 16;
            this.lblProgress.Text = "0";
            // 
            // cmdStop
            // 
            this.cmdStop.Enabled = false;
            this.cmdStop.Location = new System.Drawing.Point(309, 229);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(95, 23);
            this.cmdStop.TabIndex = 17;
            this.cmdStop.Text = "Stop";
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Sleep Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(228, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "After";
            // 
            // txtSleepTime
            // 
            this.txtSleepTime.Location = new System.Drawing.Point(295, 84);
            this.txtSleepTime.Name = "txtSleepTime";
            this.txtSleepTime.Size = new System.Drawing.Size(33, 20);
            this.txtSleepTime.TabIndex = 21;
            this.txtSleepTime.Text = "180";
            // 
            // txtAfter
            // 
            this.txtAfter.Location = new System.Drawing.Point(295, 106);
            this.txtAfter.Name = "txtAfter";
            this.txtAfter.Size = new System.Drawing.Size(33, 20);
            this.txtAfter.TabIndex = 22;
            this.txtAfter.Text = "100";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cmdList
            // 
            this.cmdList.Location = new System.Drawing.Point(518, 17);
            this.cmdList.Name = "cmdList";
            this.cmdList.Size = new System.Drawing.Size(75, 23);
            this.cmdList.TabIndex = 23;
            this.cmdList.Text = "View";
            this.cmdList.UseVisualStyleBackColor = true;
            this.cmdList.Click += new System.EventHandler(this.cmdList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 298);
            this.Controls.Add(this.cmdList);
            this.Controls.Add(this.txtAfter);
            this.Controls.Add(this.txtSleepTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmdStop);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdResume);
            this.Controls.Add(this.cmdPause);
            this.Controls.Add(this.lblDic2Count);
            this.Controls.Add(this.lblDic1Count);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.cmdFile);
            this.Controls.Add(this.lblDicDir);
            this.Controls.Add(this.cmdChooseDicDir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button cmdChooseDicDir;
        private System.Windows.Forms.Label lblDicDir;
        private System.Windows.Forms.Button cmdFile;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDic1Count;
        private System.Windows.Forms.Label lblDic2Count;
        private System.Windows.Forms.Button cmdPause;
        private System.Windows.Forms.Button cmdResume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSleepTime;
        private System.Windows.Forms.TextBox txtAfter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button cmdList;
    }
}

