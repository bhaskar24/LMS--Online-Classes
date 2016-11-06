namespace Online_Classes
{
    partial class eventFormShowEvent
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
            this.showEventButton = new System.Windows.Forms.Button();
            this.showEventListView = new System.Windows.Forms.ListView();
            this.Sr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.insName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.topic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.topicTextBox = new System.Windows.Forms.TextBox();
            this.evntDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.evntDateTextBox = new System.Windows.Forms.TextBox();
            this.clrRecordsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showEventButton
            // 
            this.showEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showEventButton.Location = new System.Drawing.Point(561, 333);
            this.showEventButton.Name = "showEventButton";
            this.showEventButton.Size = new System.Drawing.Size(179, 23);
            this.showEventButton.TabIndex = 26;
            this.showEventButton.Text = "Show Event";
            this.showEventButton.UseVisualStyleBackColor = true;
            this.showEventButton.Click += new System.EventHandler(this.showEventButton_Click);
            // 
            // showEventListView
            // 
            this.showEventListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Sr,
            this.insName,
            this.topic,
            this.date,
            this.time});
            this.showEventListView.FullRowSelect = true;
            this.showEventListView.GridLines = true;
            this.showEventListView.Location = new System.Drawing.Point(83, 39);
            this.showEventListView.MultiSelect = false;
            this.showEventListView.Name = "showEventListView";
            this.showEventListView.Size = new System.Drawing.Size(588, 220);
            this.showEventListView.TabIndex = 24;
            this.showEventListView.UseCompatibleStateImageBehavior = false;
            this.showEventListView.View = System.Windows.Forms.View.Details;
            // 
            // Sr
            // 
            this.Sr.Text = "Sr";
            this.Sr.Width = 35;
            // 
            // insName
            // 
            this.insName.Text = "Institute Name";
            this.insName.Width = 120;
            // 
            // topic
            // 
            this.topic.Text = "Topic";
            this.topic.Width = 300;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 70;
            // 
            // time
            // 
            this.time.Text = "Time";
            // 
            // topicTextBox
            // 
            this.topicTextBox.Location = new System.Drawing.Point(47, 265);
            this.topicTextBox.Name = "topicTextBox";
            this.topicTextBox.Size = new System.Drawing.Size(371, 20);
            this.topicTextBox.TabIndex = 23;
            this.topicTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.topicTextBox_MouseClick);
            // 
            // evntDateTimePicker
            // 
            this.evntDateTimePicker.Location = new System.Drawing.Point(530, 265);
            this.evntDateTimePicker.Name = "evntDateTimePicker";
            this.evntDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.evntDateTimePicker.TabIndex = 22;
            this.evntDateTimePicker.ValueChanged += new System.EventHandler(this.evntDateTimePicker_ValueChanged);
            // 
            // evntDateTextBox
            // 
            this.evntDateTextBox.Location = new System.Drawing.Point(424, 265);
            this.evntDateTextBox.Name = "evntDateTextBox";
            this.evntDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.evntDateTextBox.TabIndex = 23;
            this.evntDateTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.evntDateTextBox_MouseClick);
            this.evntDateTextBox.TextChanged += new System.EventHandler(this.evntDateTextBox_TextChanged);
            // 
            // clrRecordsButton
            // 
            this.clrRecordsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clrRecordsButton.Location = new System.Drawing.Point(376, 333);
            this.clrRecordsButton.Name = "clrRecordsButton";
            this.clrRecordsButton.Size = new System.Drawing.Size(179, 23);
            this.clrRecordsButton.TabIndex = 27;
            this.clrRecordsButton.Text = "Refresh";
            this.clrRecordsButton.UseVisualStyleBackColor = true;
            this.clrRecordsButton.Click += new System.EventHandler(this.clrRecordsButton_Click);
            // 
            // eventFormShowEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(782, 424);
            this.Controls.Add(this.clrRecordsButton);
            this.Controls.Add(this.showEventButton);
            this.Controls.Add(this.showEventListView);
            this.Controls.Add(this.evntDateTextBox);
            this.Controls.Add(this.topicTextBox);
            this.Controls.Add(this.evntDateTimePicker);
            this.Name = "eventFormShowEvent";
            this.Text = "eventFormShowEvent";
            this.Load += new System.EventHandler(this.eventFormShowEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showEventButton;
        private System.Windows.Forms.ListView showEventListView;
        private System.Windows.Forms.ColumnHeader Sr;
        private System.Windows.Forms.ColumnHeader insName;
        private System.Windows.Forms.ColumnHeader topic;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.TextBox topicTextBox;
        private System.Windows.Forms.DateTimePicker evntDateTimePicker;
        private System.Windows.Forms.TextBox evntDateTextBox;
        private System.Windows.Forms.Button clrRecordsButton;
    }
}