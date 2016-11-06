namespace Online_Classes
{
    partial class pNewsForm
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
            this.newsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.newsPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.fdOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.newsHTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.newsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // newsRichTextBox
            // 
            this.newsRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newsRichTextBox.Location = new System.Drawing.Point(343, 77);
            this.newsRichTextBox.Name = "newsRichTextBox";
            this.newsRichTextBox.Size = new System.Drawing.Size(264, 286);
            this.newsRichTextBox.TabIndex = 1;
            this.newsRichTextBox.Text = "";
            // 
            // submitButton
            // 
            this.submitButton.BackgroundImage = global::Online_Classes.Properties.Resources.moreBut;
            this.submitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.submitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Location = new System.Drawing.Point(666, 157);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(60, 60);
            this.submitButton.TabIndex = 2;
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // newsPictureBox
            // 
            this.newsPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.newsPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newsPictureBox.Location = new System.Drawing.Point(35, 38);
            this.newsPictureBox.Name = "newsPictureBox";
            this.newsPictureBox.Size = new System.Drawing.Size(272, 329);
            this.newsPictureBox.TabIndex = 0;
            this.newsPictureBox.TabStop = false;
            this.newsPictureBox.Click += new System.EventHandler(this.newsPictureBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(40, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tap and Upload the Image of the Topic";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(369, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tap and write the News";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(339, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(272, 294);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // fdOpenFileDialog
            // 
            this.fdOpenFileDialog.FileName = "openFileDialog";
            // 
            // newsHTextBox
            // 
            this.newsHTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newsHTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsHTextBox.Location = new System.Drawing.Point(339, 38);
            this.newsHTextBox.Name = "newsHTextBox";
            this.newsHTextBox.Size = new System.Drawing.Size(272, 27);
            this.newsHTextBox.TabIndex = 4;
            this.newsHTextBox.Text = "Enter Headline";
            // 
            // pNewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(749, 410);
            this.Controls.Add(this.newsHTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.newsPictureBox);
            this.Controls.Add(this.newsRichTextBox);
            this.Controls.Add(this.pictureBox2);
            this.Name = "pNewsForm";
            this.Text = "pNewsForm";
            ((System.ComponentModel.ISupportInitialize)(this.newsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox newsPictureBox;
        private System.Windows.Forms.RichTextBox newsRichTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog fdOpenFileDialog;
        private System.Windows.Forms.TextBox newsHTextBox;
    }
}