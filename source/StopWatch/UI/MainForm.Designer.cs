/**************************************************************************
Copyright 2016 Carsten Gehling

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
**************************************************************************/
namespace StopWatch
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pbSettings = new System.Windows.Forms.PictureBox();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.lblActiveFilter = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.tbTotalTime = new System.Windows.Forms.TextBox();
            this.pMain = new System.Windows.Forms.Panel();
            this.pbAddIssue = new System.Windows.Forms.PictureBox();
            this.ttMain = new System.Windows.Forms.ToolTip(this.components);
            this.pbHelp = new System.Windows.Forms.PictureBox();
            this.pTop = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timerShow = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddIssue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).BeginInit();
            this.pTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbSettings
            // 
            this.pbSettings.BackgroundImage = global::StopWatch.Properties.Resources.settings22;
            this.pbSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSettings.Location = new System.Drawing.Point(767, 2);
            this.pbSettings.Margin = new System.Windows.Forms.Padding(2);
            this.pbSettings.Name = "pbSettings";
            this.pbSettings.Size = new System.Drawing.Size(21, 21);
            this.pbSettings.TabIndex = 0;
            this.pbSettings.TabStop = false;
            this.ttMain.SetToolTip(this.pbSettings, "Configure Jira Stopwatch");
            this.pbSettings.Click += new System.EventHandler(this.pbSettings_Click);
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblConnectionStatus.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblConnectionStatus.Location = new System.Drawing.Point(609, 5);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(153, 17);
            this.lblConnectionStatus.TabIndex = 3;
            this.lblConnectionStatus.Text = "x";
            this.lblConnectionStatus.Click += new System.EventHandler(this.lblConnectionStatus_Click);
            this.lblConnectionStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblConnectionStatus_MouseDown);
            // 
            // cbFilters
            // 
            this.cbFilters.DropDownWidth = 422;
            this.cbFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Location = new System.Drawing.Point(56, 2);
            this.cbFilters.Margin = new System.Windows.Forms.Padding(2);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(319, 21);
            this.cbFilters.TabIndex = 4;
            this.cbFilters.DropDown += new System.EventHandler(this.cbFilters_DropDown);
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // lblActiveFilter
            // 
            this.lblActiveFilter.AutoSize = true;
            this.lblActiveFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblActiveFilter.ForeColor = System.Drawing.Color.White;
            this.lblActiveFilter.Location = new System.Drawing.Point(12, 6);
            this.lblActiveFilter.Name = "lblActiveFilter";
            this.lblActiveFilter.Size = new System.Drawing.Size(29, 13);
            this.lblActiveFilter.TabIndex = 5;
            this.lblActiveFilter.Text = "Filter";
            this.lblActiveFilter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblActiveFilter_MouseDown);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "JIRA StopWatch";
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblTotalTime.Location = new System.Drawing.Point(451, 6);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(31, 13);
            this.lblTotalTime.TabIndex = 6;
            this.lblTotalTime.Text = "Total";
            this.lblTotalTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbTotalTime
            // 
            this.tbTotalTime.BackColor = System.Drawing.SystemColors.Window;
            this.tbTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalTime.Location = new System.Drawing.Point(493, 2);
            this.tbTotalTime.Name = "tbTotalTime";
            this.tbTotalTime.ReadOnly = true;
            this.tbTotalTime.Size = new System.Drawing.Size(102, 20);
            this.tbTotalTime.TabIndex = 8;
            this.tbTotalTime.Text = "2D 45H 34M";
            this.tbTotalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.SystemColors.Window;
            this.pMain.Location = new System.Drawing.Point(0, 26);
            this.pMain.Margin = new System.Windows.Forms.Padding(0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(880, 30);
            this.pMain.TabIndex = 9;
            // 
            // pbAddIssue
            // 
            this.pbAddIssue.BackgroundImage = global::StopWatch.Properties.Resources.addissue22;
            this.pbAddIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddIssue.Location = new System.Drawing.Point(379, 2);
            this.pbAddIssue.Margin = new System.Windows.Forms.Padding(2);
            this.pbAddIssue.Name = "pbAddIssue";
            this.pbAddIssue.Size = new System.Drawing.Size(21, 21);
            this.pbAddIssue.TabIndex = 11;
            this.pbAddIssue.TabStop = false;
            this.ttMain.SetToolTip(this.pbAddIssue, "Add another issue row (CTRL-N)");
            this.pbAddIssue.Click += new System.EventHandler(this.pbAddIssue_Clicked);
            // 
            // pbHelp
            // 
            this.pbHelp.BackgroundImage = global::StopWatch.Properties.Resources.help22;
            this.pbHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHelp.Location = new System.Drawing.Point(794, 2);
            this.pbHelp.Name = "pbHelp";
            this.pbHelp.Size = new System.Drawing.Size(21, 21);
            this.pbHelp.TabIndex = 12;
            this.pbHelp.TabStop = false;
            this.ttMain.SetToolTip(this.pbHelp, "Open help page in your browser");
            this.pbHelp.Click += new System.EventHandler(this.pbHelp_Click);
            // 
            // pTop
            // 
            this.pTop.BackColor = System.Drawing.Color.Gray;
            this.pTop.Controls.Add(this.button2);
            this.pTop.Controls.Add(this.button1);
            this.pTop.Controls.Add(this.pbHelp);
            this.pTop.Controls.Add(this.pbSettings);
            this.pTop.Controls.Add(this.tbTotalTime);
            this.pTop.Controls.Add(this.lblActiveFilter);
            this.pTop.Controls.Add(this.cbFilters);
            this.pTop.Controls.Add(this.lblTotalTime);
            this.pTop.Controls.Add(this.pbAddIssue);
            this.pTop.Controls.Add(this.lblConnectionStatus);
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(880, 25);
            this.pTop.TabIndex = 11;
            this.pTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pTop_MouseDown);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(824, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 21);
            this.button2.TabIndex = 0;
            this.button2.Text = "_";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(851, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 21);
            this.button1.TabIndex = 13;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timerShow
            // 
            this.timerShow.Interval = 2000;
            this.timerShow.Tick += new System.EventHandler(this.timerShow_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(880, 56);
            this.Controls.Add(this.pTop);
            this.Controls.Add(this.pMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::StopWatch.Properties.Resources.stopwatchicon;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "JIRA StopWatch";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddIssue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).EndInit();
            this.pTop.ResumeLayout(false);
            this.pTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSettings;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Label lblActiveFilter;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.TextBox tbTotalTime;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.ToolTip ttMain;
        private System.Windows.Forms.PictureBox pbAddIssue;
        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.PictureBox pbHelp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timerShow;
    }
}

