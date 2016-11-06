namespace Online_Classes
{
    partial class eventVideoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
       
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eventVideoForm));
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.lecturesPanel = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.playButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.videosListView = new System.Windows.Forms.ListView();
            this.srNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.instituteName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Topic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.selectedValueTextBox = new System.Windows.Forms.TextBox();
            this.selectedValue2TextBox = new System.Windows.Forms.TextBox();
            this.fullScreenButton = new System.Windows.Forms.Button();
            this.lecturesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(912, 225);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(100, 20);
            this.pathTextBox.TabIndex = 0;
            // 
            // lecturesPanel
            // 
            this.lecturesPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lecturesPanel.Controls.Add(this.axWindowsMediaPlayer1);
            this.lecturesPanel.Location = new System.Drawing.Point(23, 73);
            this.lecturesPanel.Name = "lecturesPanel";
            this.lecturesPanel.Size = new System.Drawing.Size(700, 390);
            this.lecturesPanel.TabIndex = 1;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(700, 390);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.VisibleChanged += new System.EventHandler(this.axWindowsMediaPlayer1_VisibleChanged);
            // 
            // playButton
            // 
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Location = new System.Drawing.Point(922, 440);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseButton.Location = new System.Drawing.Point(998, 440);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 23);
            this.pauseButton.TabIndex = 3;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Location = new System.Drawing.Point(1074, 440);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Location = new System.Drawing.Point(770, 440);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1254, 486);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 748;
            this.lineShape1.X2 = 748;
            this.lineShape1.Y1 = 32;
            this.lineShape1.Y2 = 480;
            // 
            // videosListView
            // 
            this.videosListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.srNum,
            this.instituteName,
            this.Topic,
            this.Date,
            this.time,
            this.Path});
            this.videosListView.FullRowSelect = true;
            this.videosListView.GridLines = true;
            this.videosListView.Location = new System.Drawing.Point(767, 73);
            this.videosListView.MultiSelect = false;
            this.videosListView.Name = "videosListView";
            this.videosListView.Size = new System.Drawing.Size(382, 361);
            this.videosListView.TabIndex = 23;
            this.videosListView.UseCompatibleStateImageBehavior = false;
            this.videosListView.View = System.Windows.Forms.View.Details;
            // 
            // srNum
            // 
            this.srNum.Text = "Sr";
            this.srNum.Width = 30;
            // 
            // instituteName
            // 
            this.instituteName.Text = "Institute Name";
            this.instituteName.Width = 120;
            // 
            // Topic
            // 
            this.Topic.Text = "Topic";
            this.Topic.Width = 118;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            // 
            // time
            // 
            this.time.Text = "Time";
            this.time.Width = 65;
            // 
            // Path
            // 
            this.Path.Text = "Video Path";
            this.Path.Width = 0;
            // 
            // selectedValueTextBox
            // 
            this.selectedValueTextBox.Location = new System.Drawing.Point(815, 169);
            this.selectedValueTextBox.Name = "selectedValueTextBox";
            this.selectedValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.selectedValueTextBox.TabIndex = 24;
            // 
            // selectedValue2TextBox
            // 
            this.selectedValue2TextBox.Location = new System.Drawing.Point(942, 168);
            this.selectedValue2TextBox.Name = "selectedValue2TextBox";
            this.selectedValue2TextBox.Size = new System.Drawing.Size(100, 20);
            this.selectedValue2TextBox.TabIndex = 25;
            // 
            // fullScreenButton
            // 
            this.fullScreenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullScreenButton.Location = new System.Drawing.Point(846, 440);
            this.fullScreenButton.Name = "fullScreenButton";
            this.fullScreenButton.Size = new System.Drawing.Size(75, 23);
            this.fullScreenButton.TabIndex = 26;
            this.fullScreenButton.Text = "Full Screen";
            this.fullScreenButton.UseVisualStyleBackColor = true;
            this.fullScreenButton.Click += new System.EventHandler(this.fullScreenButton_Click);
            // 
            // eventVideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1254, 486);
            this.Controls.Add(this.fullScreenButton);
            this.Controls.Add(this.lecturesPanel);
            this.Controls.Add(this.videosListView);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.selectedValue2TextBox);
            this.Controls.Add(this.selectedValueTextBox);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "eventVideoForm";
            this.Text = "eventVideoForm";
            this.Load += new System.EventHandler(this.eventVideoForm_Load);
            this.lecturesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Panel lecturesPanel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button refreshButton;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.ListView videosListView;
        private System.Windows.Forms.ColumnHeader srNum;
        private System.Windows.Forms.ColumnHeader instituteName;
        private System.Windows.Forms.ColumnHeader Topic;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.TextBox selectedValueTextBox;
        private System.Windows.Forms.TextBox selectedValue2TextBox;
        private System.Windows.Forms.ColumnHeader Path;
        private System.Windows.Forms.Button fullScreenButton;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}