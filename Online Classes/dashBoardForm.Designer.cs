namespace Online_Classes
{
    partial class dashBoardForm
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
            this.allEventsDetailListView = new System.Windows.Forms.ListView();
            this.sr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.insName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.topic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.classOfferedLabel = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.searchButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.searchFieldTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // allEventsDetailListView
            // 
            this.allEventsDetailListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sr,
            this.insName,
            this.topic,
            this.date,
            this.time});
            this.allEventsDetailListView.FullRowSelect = true;
            this.allEventsDetailListView.GridLines = true;
            this.allEventsDetailListView.Location = new System.Drawing.Point(71, 117);
            this.allEventsDetailListView.MultiSelect = false;
            this.allEventsDetailListView.Name = "allEventsDetailListView";
            this.allEventsDetailListView.Size = new System.Drawing.Size(1083, 316);
            this.allEventsDetailListView.TabIndex = 14;
            this.allEventsDetailListView.UseCompatibleStateImageBehavior = false;
            this.allEventsDetailListView.View = System.Windows.Forms.View.Details;
            // 
            // sr
            // 
            this.sr.Text = "Sr";
            this.sr.Width = 0;
            // 
            // insName
            // 
            this.insName.Text = "Institute Name/College Name";
            this.insName.Width = 478;
            // 
            // topic
            // 
            this.topic.Text = "Topic";
            this.topic.Width = 380;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 99;
            // 
            // time
            // 
            this.time.Text = "Time";
            this.time.Width = 107;
            // 
            // classOfferedLabel
            // 
            this.classOfferedLabel.AutoSize = true;
            this.classOfferedLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.classOfferedLabel.Location = new System.Drawing.Point(503, 73);
            this.classOfferedLabel.Name = "classOfferedLabel";
            this.classOfferedLabel.Size = new System.Drawing.Size(174, 13);
            this.classOfferedLabel.TabIndex = 15;
            this.classOfferedLabel.Text = "Classes Offered All Over The World";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1253, 506);
            this.shapeContainer1.TabIndex = 16;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 230;
            this.lineShape1.X2 = 1001;
            this.lineShape1.Y1 = 80;
            this.lineShape1.Y2 = 80;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(883, 438);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(170, 23);
            this.searchButton.TabIndex = 17;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Location = new System.Drawing.Point(707, 438);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(170, 23);
            this.refreshButton.TabIndex = 18;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // searchFieldTextBox
            // 
            this.searchFieldTextBox.Location = new System.Drawing.Point(171, 440);
            this.searchFieldTextBox.Name = "searchFieldTextBox";
            this.searchFieldTextBox.Size = new System.Drawing.Size(530, 20);
            this.searchFieldTextBox.TabIndex = 19;
            this.searchFieldTextBox.Click += new System.EventHandler(this.searchFieldTextBox_Click);
            // 
            // dashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Online_Classes.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(1253, 506);
            this.Controls.Add(this.searchFieldTextBox);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.classOfferedLabel);
            this.Controls.Add(this.allEventsDetailListView);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "dashBoardForm";
            this.Text = "Dash Board";
            this.Load += new System.EventHandler(this.dashBoardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView allEventsDetailListView;
        private System.Windows.Forms.ColumnHeader sr;
        private System.Windows.Forms.ColumnHeader insName;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader topic;
        private System.Windows.Forms.Label classOfferedLabel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox searchFieldTextBox;

    }
}