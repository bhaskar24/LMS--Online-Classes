namespace Online_Classes
{
    partial class studProbForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.queryRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.replyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.replyButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.queryRichTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(12, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 328);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Students Query";
            // 
            // queryRichTextBox
            // 
            this.queryRichTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.queryRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.queryRichTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.queryRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryRichTextBox.Location = new System.Drawing.Point(6, 16);
            this.queryRichTextBox.Name = "queryRichTextBox";
            this.queryRichTextBox.ReadOnly = true;
            this.queryRichTextBox.Size = new System.Drawing.Size(315, 306);
            this.queryRichTextBox.TabIndex = 12;
            this.queryRichTextBox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.replyRichTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(414, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 328);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reply";
            // 
            // replyRichTextBox
            // 
            this.replyRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.replyRichTextBox.Location = new System.Drawing.Point(6, 38);
            this.replyRichTextBox.Name = "replyRichTextBox";
            this.replyRichTextBox.Size = new System.Drawing.Size(316, 284);
            this.replyRichTextBox.TabIndex = 1;
            this.replyRichTextBox.Text = "";
            this.replyRichTextBox.Click += new System.EventHandler(this.replyRichTextBox_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Location = new System.Drawing.Point(6, 16);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(316, 16);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Click += new System.EventHandler(this.nameTextBox_Click);
            // 
            // replyButton
            // 
            this.replyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.replyButton.Location = new System.Drawing.Point(300, 381);
            this.replyButton.Name = "replyButton";
            this.replyButton.Size = new System.Drawing.Size(170, 23);
            this.replyButton.TabIndex = 16;
            this.replyButton.Text = "Reply";
            this.replyButton.UseVisualStyleBackColor = true;
            this.replyButton.Click += new System.EventHandler(this.replyButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // studProbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(894, 494);
            this.Controls.Add(this.replyButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "studProbForm";
            this.Text = "studProbForm";
            this.Load += new System.EventHandler(this.studProbForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox queryRichTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox replyRichTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button replyButton;
        private System.Windows.Forms.Timer timer1;
    }
}