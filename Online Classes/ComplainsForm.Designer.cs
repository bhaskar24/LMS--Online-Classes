namespace Online_Classes
{
    partial class ComplainsForm
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
            this.compRichTextBox = new System.Windows.Forms.RichTextBox();
            this.subButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // compRichTextBox
            // 
            this.compRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.compRichTextBox.Location = new System.Drawing.Point(15, 22);
            this.compRichTextBox.Name = "compRichTextBox";
            this.compRichTextBox.Size = new System.Drawing.Size(603, 187);
            this.compRichTextBox.TabIndex = 0;
            this.compRichTextBox.Text = "";
            // 
            // subButton
            // 
            this.subButton.BackgroundImage = global::Online_Classes.Properties.Resources.moreBut;
            this.subButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.subButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.subButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subButton.Location = new System.Drawing.Point(917, 209);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(60, 60);
            this.subButton.TabIndex = 1;
            this.subButton.UseVisualStyleBackColor = true;
            this.subButton.Click += new System.EventHandler(this.subButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.compRichTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(265, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 224);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter your Complains or Suggestion ";
            // 
            // ComplainsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Online_Classes.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(1252, 487);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.subButton);
            this.Name = "ComplainsForm";
            this.Text = "ComplainsForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox compRichTextBox;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}