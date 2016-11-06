namespace Online_Classes
{
    partial class EBookForm
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
            this.pdfPanel = new System.Windows.Forms.Panel();
            this.videosListView = new System.Windows.Forms.ListView();
            this.bookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showBbutton = new System.Windows.Forms.Button();
            this.pdfPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pdfPanel
            // 
            this.pdfPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pdfPanel.Controls.Add(this.videosListView);
            this.pdfPanel.Location = new System.Drawing.Point(2, 1);
            this.pdfPanel.Name = "pdfPanel";
            this.pdfPanel.Size = new System.Drawing.Size(1178, 422);
            this.pdfPanel.TabIndex = 0;
            // 
            // videosListView
            // 
            this.videosListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bookName});
            this.videosListView.FullRowSelect = true;
            this.videosListView.GridLines = true;
            this.videosListView.Location = new System.Drawing.Point(10, 11);
            this.videosListView.MultiSelect = false;
            this.videosListView.Name = "videosListView";
            this.videosListView.Size = new System.Drawing.Size(1159, 408);
            this.videosListView.TabIndex = 24;
            this.videosListView.UseCompatibleStateImageBehavior = false;
            this.videosListView.View = System.Windows.Forms.View.Details;
            // 
            // bookName
            // 
            this.bookName.Text = "Book Name";
            this.bookName.Width = 1120;
            // 
            // showBbutton
            // 
            this.showBbutton.BackgroundImage = global::Online_Classes.Properties.Resources.moreBut;
            this.showBbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showBbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.showBbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showBbutton.Location = new System.Drawing.Point(560, 429);
            this.showBbutton.Name = "showBbutton";
            this.showBbutton.Size = new System.Drawing.Size(60, 60);
            this.showBbutton.TabIndex = 1;
            this.showBbutton.UseVisualStyleBackColor = true;
            this.showBbutton.Click += new System.EventHandler(this.showBbutton_Click);
            // 
            // EBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1183, 489);
            this.Controls.Add(this.showBbutton);
            this.Controls.Add(this.pdfPanel);
            this.Name = "EBookForm";
            this.Text = "EBookForm";
            this.Load += new System.EventHandler(this.EBookForm_Load);
            this.pdfPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pdfPanel;
        private System.Windows.Forms.Button showBbutton;
        private System.Windows.Forms.ListView videosListView;
        private System.Windows.Forms.ColumnHeader bookName;
    }
}