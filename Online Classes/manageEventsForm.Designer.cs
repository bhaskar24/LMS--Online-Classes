namespace Online_Classes
{
    partial class manageEventsForm
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
            this.videosListView = new System.Windows.Forms.ListView();
            this.srNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.instituteName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Topic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.videosListView.Location = new System.Drawing.Point(10, 43);
            this.videosListView.MultiSelect = false;
            this.videosListView.Name = "videosListView";
            this.videosListView.Size = new System.Drawing.Size(719, 341);
            this.videosListView.TabIndex = 24;
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
            this.instituteName.Width = 250;
            // 
            // Topic
            // 
            this.Topic.Text = "Topic";
            this.Topic.Width = 270;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 80;
            // 
            // time
            // 
            this.time.Text = "Time";
            this.time.Width = 80;
            // 
            // Path
            // 
            this.Path.Text = "Video Path";
            this.Path.Width = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.BackgroundImage = global::Online_Classes.Properties.Resources.moreBut;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteButton.Location = new System.Drawing.Point(735, 179);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(60, 60);
            this.deleteButton.TabIndex = 25;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // manageEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(885, 453);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.videosListView);
            this.Name = "manageEventsForm";
            this.Text = "manageEventsForm";
            this.Load += new System.EventHandler(this.manageEventsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView videosListView;
        private System.Windows.Forms.ColumnHeader srNum;
        private System.Windows.Forms.ColumnHeader instituteName;
        private System.Windows.Forms.ColumnHeader Topic;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader Path;
        private System.Windows.Forms.Button deleteButton;
    }
}