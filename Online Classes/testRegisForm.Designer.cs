namespace Online_Classes
{
    partial class testRegisForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tnTextBox = new System.Windows.Forms.TextBox();
            this.startTestButton = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label2 = new System.Windows.Forms.Label();
            this.uIdTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.testnLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.notifiRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Unique Id";
            // 
            // tnTextBox
            // 
            this.tnTextBox.Location = new System.Drawing.Point(172, 252);
            this.tnTextBox.Name = "tnTextBox";
            this.tnTextBox.Size = new System.Drawing.Size(203, 20);
            this.tnTextBox.TabIndex = 1;
            // 
            // startTestButton
            // 
            this.startTestButton.BackgroundImage = global::Online_Classes.Properties.Resources.moreBut;
            this.startTestButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startTestButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.startTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startTestButton.Location = new System.Drawing.Point(710, 128);
            this.startTestButton.Name = "startTestButton";
            this.startTestButton.Size = new System.Drawing.Size(67, 64);
            this.startTestButton.TabIndex = 2;
            this.startTestButton.UseVisualStyleBackColor = true;
            this.startTestButton.Click += new System.EventHandler(this.startTestButton_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1251, 479);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 387;
            this.lineShape1.X2 = 387;
            this.lineShape1.Y1 = 73;
            this.lineShape1.Y2 = 426;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Technology Name";
            // 
            // uIdTextBox
            // 
            this.uIdTextBox.Location = new System.Drawing.Point(172, 198);
            this.uIdTextBox.Name = "uIdTextBox";
            this.uIdTextBox.Size = new System.Drawing.Size(203, 20);
            this.uIdTextBox.TabIndex = 1;
            this.uIdTextBox.Enter += new System.EventHandler(this.uIdTextBox_Enter);
            this.uIdTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.uIdTextBox_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.testnLabel);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.startTestButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.notifiRichTextBox);
            this.groupBox1.Location = new System.Drawing.Point(404, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 289);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // testnLabel
            // 
            this.testnLabel.AutoSize = true;
            this.testnLabel.ForeColor = System.Drawing.Color.Gray;
            this.testnLabel.Location = new System.Drawing.Point(707, 25);
            this.testnLabel.Name = "testnLabel";
            this.testnLabel.Size = new System.Drawing.Size(34, 13);
            this.testnLabel.TabIndex = 4;
            this.testnLabel.Text = "00:30";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(637, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Time Alloted";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(177, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(495, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Don\'t try to open anything in between the test,otherwise test will be automatical" +
    "ly submitted at that case.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "* Each question carry 1 mark,no negative marks.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(411, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "* Don\'t refresh the page ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "* Time alloted : 30 minutes.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(411, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "* Test will be submitted automatically if the time exired.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(411, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "* Click the \'Submit Test\' to submit your answer.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "* Total number of question:20.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Instruction:";
            // 
            // notifiRichTextBox
            // 
            this.notifiRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notifiRichTextBox.Location = new System.Drawing.Point(7, 14);
            this.notifiRichTextBox.Name = "notifiRichTextBox";
            this.notifiRichTextBox.Size = new System.Drawing.Size(772, 267);
            this.notifiRichTextBox.TabIndex = 0;
            this.notifiRichTextBox.Text = "";
            // 
            // testRegisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1251, 479);
            this.Controls.Add(this.uIdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tnTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "testRegisForm";
            this.Text = "testRegisForm";
            this.Load += new System.EventHandler(this.testRegisForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tnTextBox;
        private System.Windows.Forms.Button startTestButton;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uIdTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox notifiRichTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label testnLabel;
    }
}