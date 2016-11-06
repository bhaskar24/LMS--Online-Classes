namespace Online_Classes
{
    partial class eventFormNewEvent
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
            this.eventDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.topicTextBox = new System.Windows.Forms.TextBox();
            this.makeEventButton = new System.Windows.Forms.Button();
            this.insTextBox = new System.Windows.Forms.TextBox();
            this.showEventListView = new System.Windows.Forms.ListView();
            this.Sr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.insName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.topic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.refreshButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eventDateTimePicker
            // 
            this.eventDateTimePicker.Location = new System.Drawing.Point(568, 264);
            this.eventDateTimePicker.Name = "eventDateTimePicker";
            this.eventDateTimePicker.Size = new System.Drawing.Size(137, 20);
            this.eventDateTimePicker.TabIndex = 20;
            this.eventDateTimePicker.ValueChanged += new System.EventHandler(this.eventDateTimePicker_ValueChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(471, 143);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(299, 20);
            this.idTextBox.TabIndex = 22;
            this.idTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.idTextBox_MouseClick);
            // 
            // topicTextBox
            // 
            this.topicTextBox.Location = new System.Drawing.Point(471, 232);
            this.topicTextBox.Name = "topicTextBox";
            this.topicTextBox.Size = new System.Drawing.Size(299, 20);
            this.topicTextBox.TabIndex = 25;
            this.topicTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.topicTextBox_MouseClick);
            // 
            // makeEventButton
            // 
            this.makeEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeEventButton.Location = new System.Drawing.Point(615, 346);
            this.makeEventButton.Name = "makeEventButton";
            this.makeEventButton.Size = new System.Drawing.Size(134, 23);
            this.makeEventButton.TabIndex = 27;
            this.makeEventButton.Text = "Make An Event";
            this.makeEventButton.UseVisualStyleBackColor = true;
            this.makeEventButton.Click += new System.EventHandler(this.makeEventButton_Click);
            // 
            // insTextBox
            // 
            this.insTextBox.Location = new System.Drawing.Point(471, 186);
            this.insTextBox.Name = "insTextBox";
            this.insTextBox.Size = new System.Drawing.Size(299, 20);
            this.insTextBox.TabIndex = 26;
            this.insTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.insTextBox_MouseClick);
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
            this.showEventListView.Location = new System.Drawing.Point(27, 125);
            this.showEventListView.MultiSelect = false;
            this.showEventListView.Name = "showEventListView";
            this.showEventListView.Size = new System.Drawing.Size(416, 244);
            this.showEventListView.TabIndex = 28;
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
            this.insName.Width = 119;
            // 
            // topic
            // 
            this.topic.Text = "Topic";
            this.topic.Width = 115;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 65;
            // 
            // time
            // 
            this.time.Text = "Time";
            this.time.Width = 66;
            // 
            // refreshButton
            // 
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Location = new System.Drawing.Point(475, 346);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(134, 23);
            this.refreshButton.TabIndex = 29;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(243, 186);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(100, 20);
            this.pathTextBox.TabIndex = 30;
            // 
            // dateTextBox
            // 
            this.dateTextBox.AutoSize = true;
            this.dateTextBox.Location = new System.Drawing.Point(492, 267);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(35, 13);
            this.dateTextBox.TabIndex = 31;
            this.dateTextBox.Text = "label1";
            // 
            // timeTextBox
            // 
            this.timeTextBox.AutoSize = true;
            this.timeTextBox.Location = new System.Drawing.Point(711, 267);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(35, 13);
            this.timeTextBox.TabIndex = 32;
            this.timeTextBox.Text = "label1";
            // 
            // eventFormNewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(782, 482);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.showEventListView);
            this.Controls.Add(this.eventDateTimePicker);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.topicTextBox);
            this.Controls.Add(this.makeEventButton);
            this.Controls.Add(this.insTextBox);
            this.Controls.Add(this.pathTextBox);
            this.Name = "eventFormNewEvent";
            this.Text = "eventFormNewEvent";
            this.Load += new System.EventHandler(this.eventFormNewEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker eventDateTimePicker;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox topicTextBox;
        private System.Windows.Forms.Button makeEventButton;
        private System.Windows.Forms.TextBox insTextBox;
        private System.Windows.Forms.ListView showEventListView;
        private System.Windows.Forms.ColumnHeader Sr;
        private System.Windows.Forms.ColumnHeader insName;
        private System.Windows.Forms.ColumnHeader topic;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label dateTextBox;
        private System.Windows.Forms.Label timeTextBox;
    }
}