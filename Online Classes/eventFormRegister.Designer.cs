namespace Online_Classes
{
    partial class eventFormRegister
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
            this.regButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.insTextBox = new System.Windows.Forms.TextBox();
            this.topicTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.videosListView = new System.Windows.Forms.ListView();
            this.sr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.insName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.topic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // regButton
            // 
            this.regButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regButton.Location = new System.Drawing.Point(455, 377);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(147, 23);
            this.regButton.TabIndex = 24;
            this.regButton.Text = "Register For Event";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(399, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 21;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(98, 377);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(351, 20);
            this.idTextBox.TabIndex = 25;
            this.idTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.idTextBox_MouseClick);
            // 
            // refreshButton
            // 
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Location = new System.Drawing.Point(608, 376);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(147, 23);
            this.refreshButton.TabIndex = 26;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // insTextBox
            // 
            this.insTextBox.Location = new System.Drawing.Point(324, 212);
            this.insTextBox.Name = "insTextBox";
            this.insTextBox.Size = new System.Drawing.Size(351, 20);
            this.insTextBox.TabIndex = 25;
            this.insTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.insTextBox_MouseClick);
            // 
            // topicTextBox
            // 
            this.topicTextBox.Location = new System.Drawing.Point(197, 178);
            this.topicTextBox.Name = "topicTextBox";
            this.topicTextBox.Size = new System.Drawing.Size(351, 20);
            this.topicTextBox.TabIndex = 25;
            this.topicTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.topicTextBox_MouseClick);
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(54, 212);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateTextBox.TabIndex = 25;
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(197, 212);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(100, 20);
            this.timeTextBox.TabIndex = 25;
            this.timeTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.timeTextBox_MouseClick);
            // 
            // videosListView
            // 
            this.videosListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sr,
            this.insName,
            this.topic,
            this.date,
            this.time,
            this.Path});
            this.videosListView.FullRowSelect = true;
            this.videosListView.GridLines = true;
            this.videosListView.Location = new System.Drawing.Point(15, 98);
            this.videosListView.MultiSelect = false;
            this.videosListView.Name = "videosListView";
            this.videosListView.Size = new System.Drawing.Size(767, 273);
            this.videosListView.TabIndex = 29;
            this.videosListView.UseCompatibleStateImageBehavior = false;
            this.videosListView.View = System.Windows.Forms.View.Details;
            // 
            // sr
            // 
            this.sr.Text = "Sr";
            this.sr.Width = 30;
            // 
            // insName
            // 
            this.insName.Text = "Institute Name";
            this.insName.Width = 200;
            // 
            // topic
            // 
            this.topic.Text = "Topic";
            this.topic.Width = 180;
            // 
            // date
            // 
            this.date.Text = "Date";
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
            // eventFormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1007, 480);
            this.Controls.Add(this.videosListView);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.topicTextBox);
            this.Controls.Add(this.insTextBox);
            this.Name = "eventFormRegister";
            this.Text = "eventFormRegister";
            this.Load += new System.EventHandler(this.eventFormRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox insTextBox;
        private System.Windows.Forms.TextBox topicTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.ListView videosListView;
        private System.Windows.Forms.ColumnHeader sr;
        private System.Windows.Forms.ColumnHeader insName;
        private System.Windows.Forms.ColumnHeader topic;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader Path;
    }
}