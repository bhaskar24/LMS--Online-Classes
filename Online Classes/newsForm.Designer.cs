namespace Online_Classes
{
    partial class newsForm
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.newsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.moreButton = new System.Windows.Forms.Button();
            this.newsPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nhRichTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.newsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1223, 515);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 589;
            this.lineShape1.X2 = 589;
            this.lineShape1.Y1 = 76;
            this.lineShape1.Y2 = 406;
            // 
            // newsRichTextBox
            // 
            this.newsRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newsRichTextBox.Location = new System.Drawing.Point(646, 129);
            this.newsRichTextBox.Name = "newsRichTextBox";
            this.newsRichTextBox.Size = new System.Drawing.Size(448, 230);
            this.newsRichTextBox.TabIndex = 2;
            this.newsRichTextBox.Text = "";
            // 
            // moreButton
            // 
            this.moreButton.BackgroundImage = global::Online_Classes.Properties.Resources.moreButton2;
            this.moreButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moreButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.moreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moreButton.Location = new System.Drawing.Point(563, 417);
            this.moreButton.Name = "moreButton";
            this.moreButton.Size = new System.Drawing.Size(60, 60);
            this.moreButton.TabIndex = 3;
            this.moreButton.UseVisualStyleBackColor = true;
            this.moreButton.Click += new System.EventHandler(this.moreButton_Click);
            // 
            // newsPictureBox
            // 
            this.newsPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.newsPictureBox.Location = new System.Drawing.Point(114, 125);
            this.newsPictureBox.Name = "newsPictureBox";
            this.newsPictureBox.Size = new System.Drawing.Size(458, 238);
            this.newsPictureBox.TabIndex = 0;
            this.newsPictureBox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(641, 125);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(458, 238);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // nhRichTextBox
            // 
            this.nhRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nhRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhRichTextBox.Location = new System.Drawing.Point(240, 26);
            this.nhRichTextBox.Name = "nhRichTextBox";
            this.nhRichTextBox.Size = new System.Drawing.Size(814, 42);
            this.nhRichTextBox.TabIndex = 4;
            this.nhRichTextBox.Text = "";
            // 
            // newsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1223, 515);
            this.Controls.Add(this.nhRichTextBox);
            this.Controls.Add(this.moreButton);
            this.Controls.Add(this.newsRichTextBox);
            this.Controls.Add(this.newsPictureBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "newsForm";
            this.Text = "newsForm";
            this.Load += new System.EventHandler(this.newsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox newsPictureBox;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.RichTextBox newsRichTextBox;
        private System.Windows.Forms.Button moreButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox nhRichTextBox;
    }
}