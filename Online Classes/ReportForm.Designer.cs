namespace Online_Classes
{
    partial class ReportForm
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
            this.testRecordListView = new System.Windows.Forms.ListView();
            this.sr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.testName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maxMarks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.obtainMarks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // testRecordListView
            // 
            this.testRecordListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.testRecordListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sr,
            this.testName,
            this.duration,
            this.Date,
            this.maxMarks,
            this.obtainMarks,
            this.status});
            this.testRecordListView.FullRowSelect = true;
            this.testRecordListView.GridLines = true;
            this.testRecordListView.Location = new System.Drawing.Point(253, 61);
            this.testRecordListView.MultiSelect = false;
            this.testRecordListView.Name = "testRecordListView";
            this.testRecordListView.Size = new System.Drawing.Size(754, 339);
            this.testRecordListView.TabIndex = 24;
            this.testRecordListView.UseCompatibleStateImageBehavior = false;
            this.testRecordListView.View = System.Windows.Forms.View.Details;
            // 
            // sr
            // 
            this.sr.Text = "Sr";
            this.sr.Width = 30;
            // 
            // testName
            // 
            this.testName.Text = "Test Name";
            this.testName.Width = 120;
            // 
            // duration
            // 
            this.duration.Text = "duration";
            this.duration.Width = 120;
            // 
            // Date
            // 
            this.Date.Text = "Date & Time";
            this.Date.Width = 140;
            // 
            // maxMarks
            // 
            this.maxMarks.Text = "Total Marks";
            this.maxMarks.Width = 120;
            // 
            // obtainMarks
            // 
            this.obtainMarks.Text = "Obtain Marks";
            this.obtainMarks.Width = 120;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 100;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Online_Classes.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(1251, 482);
            this.Controls.Add(this.testRecordListView);
            this.Name = "ReportForm";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView testRecordListView;
        private System.Windows.Forms.ColumnHeader sr;
        private System.Windows.Forms.ColumnHeader testName;
        private System.Windows.Forms.ColumnHeader duration;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader maxMarks;
        private System.Windows.Forms.ColumnHeader obtainMarks;
        private System.Windows.Forms.ColumnHeader status;


    }
}