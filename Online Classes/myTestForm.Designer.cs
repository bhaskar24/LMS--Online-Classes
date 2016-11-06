namespace Online_Classes
{
    partial class myTestForm
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
            this.queRichTextBox = new System.Windows.Forms.RichTextBox();
            this.opt1TextBox = new System.Windows.Forms.TextBox();
            this.opt3TextBox = new System.Windows.Forms.TextBox();
            this.opt4TextBox = new System.Windows.Forms.TextBox();
            this.correctAnsTextBox = new System.Windows.Forms.TextBox();
            this.enterQueLabel = new System.Windows.Forms.Label();
            this.queRecordCounterLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.opt2TextBox = new System.Windows.Forms.TextBox();
            this.totalQueLabel = new System.Windows.Forms.Label();
            this.nQuestionLabel = new System.Windows.Forms.Label();
            this.subButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.nQStextBox = new System.Windows.Forms.TextBox();
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.testNameTextBox = new System.Windows.Forms.TextBox();
            this.nquesTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // queRichTextBox
            // 
            this.queRichTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.queRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.queRichTextBox.Location = new System.Drawing.Point(6, 62);
            this.queRichTextBox.Name = "queRichTextBox";
            this.queRichTextBox.Size = new System.Drawing.Size(77, 205);
            this.queRichTextBox.TabIndex = 6;
            this.queRichTextBox.Text = "";
            this.queRichTextBox.Click += new System.EventHandler(this.queRichTextBox_Click);
            // 
            // opt1TextBox
            // 
            this.opt1TextBox.Location = new System.Drawing.Point(98, 62);
            this.opt1TextBox.Name = "opt1TextBox";
            this.opt1TextBox.Size = new System.Drawing.Size(239, 20);
            this.opt1TextBox.TabIndex = 7;
            this.opt1TextBox.Text = "Enter 1st Option";
            this.opt1TextBox.Click += new System.EventHandler(this.opt1TextBox_Click);
            // 
            // opt3TextBox
            // 
            this.opt3TextBox.Location = new System.Drawing.Point(98, 114);
            this.opt3TextBox.Name = "opt3TextBox";
            this.opt3TextBox.Size = new System.Drawing.Size(239, 20);
            this.opt3TextBox.TabIndex = 7;
            this.opt3TextBox.Text = "Enter 3rd Option";
            this.opt3TextBox.Click += new System.EventHandler(this.opt3TextBox_Click);
            // 
            // opt4TextBox
            // 
            this.opt4TextBox.Location = new System.Drawing.Point(98, 140);
            this.opt4TextBox.Name = "opt4TextBox";
            this.opt4TextBox.Size = new System.Drawing.Size(239, 20);
            this.opt4TextBox.TabIndex = 7;
            this.opt4TextBox.Text = "Enter 4th Option";
            this.opt4TextBox.Click += new System.EventHandler(this.opt4TextBox_Click);
            // 
            // correctAnsTextBox
            // 
            this.correctAnsTextBox.Location = new System.Drawing.Point(98, 216);
            this.correctAnsTextBox.Name = "correctAnsTextBox";
            this.correctAnsTextBox.Size = new System.Drawing.Size(239, 20);
            this.correctAnsTextBox.TabIndex = 7;
            this.correctAnsTextBox.Text = "Enter Correct Answer";
            this.correctAnsTextBox.Click += new System.EventHandler(this.correctAnsTextBox_Click);
            // 
            // enterQueLabel
            // 
            this.enterQueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.enterQueLabel.AutoSize = true;
            this.enterQueLabel.Location = new System.Drawing.Point(95, 30);
            this.enterQueLabel.Name = "enterQueLabel";
            this.enterQueLabel.Size = new System.Drawing.Size(69, 13);
            this.enterQueLabel.TabIndex = 8;
            this.enterQueLabel.Text = "Question No:";
            // 
            // queRecordCounterLabel
            // 
            this.queRecordCounterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.queRecordCounterLabel.AutoSize = true;
            this.queRecordCounterLabel.Location = new System.Drawing.Point(198, 30);
            this.queRecordCounterLabel.Name = "queRecordCounterLabel";
            this.queRecordCounterLabel.Size = new System.Drawing.Size(13, 13);
            this.queRecordCounterLabel.TabIndex = 8;
            this.queRecordCounterLabel.Text = "0";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.correctAnsTextBox);
            this.panel2.Controls.Add(this.opt2TextBox);
            this.panel2.Controls.Add(this.queRichTextBox);
            this.panel2.Controls.Add(this.opt3TextBox);
            this.panel2.Controls.Add(this.totalQueLabel);
            this.panel2.Controls.Add(this.opt4TextBox);
            this.panel2.Controls.Add(this.nQuestionLabel);
            this.panel2.Controls.Add(this.opt1TextBox);
            this.panel2.Controls.Add(this.queRecordCounterLabel);
            this.panel2.Controls.Add(this.enterQueLabel);
            this.panel2.Location = new System.Drawing.Point(835, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(828, 422);
            this.panel2.TabIndex = 9;
            // 
            // opt2TextBox
            // 
            this.opt2TextBox.Location = new System.Drawing.Point(98, 88);
            this.opt2TextBox.Name = "opt2TextBox";
            this.opt2TextBox.Size = new System.Drawing.Size(239, 20);
            this.opt2TextBox.TabIndex = 11;
            this.opt2TextBox.Text = "Enter 2nd Option";
            this.opt2TextBox.Click += new System.EventHandler(this.opt2TextBox_Click);
            // 
            // totalQueLabel
            // 
            this.totalQueLabel.AutoSize = true;
            this.totalQueLabel.Location = new System.Drawing.Point(95, 9);
            this.totalQueLabel.Name = "totalQueLabel";
            this.totalQueLabel.Size = new System.Drawing.Size(133, 13);
            this.totalQueLabel.TabIndex = 9;
            this.totalQueLabel.Text = "Total Number Of Question:";
            // 
            // nQuestionLabel
            // 
            this.nQuestionLabel.AutoSize = true;
            this.nQuestionLabel.Location = new System.Drawing.Point(231, 9);
            this.nQuestionLabel.Name = "nQuestionLabel";
            this.nQuestionLabel.Size = new System.Drawing.Size(13, 13);
            this.nQuestionLabel.TabIndex = 9;
            this.nQuestionLabel.Text = "0";
            // 
            // subButton
            // 
            this.subButton.BackgroundImage = global::Online_Classes.Properties.Resources.moreBut;
            this.subButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.subButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.subButton.Location = new System.Drawing.Point(523, 438);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(64, 64);
            this.subButton.TabIndex = 10;
            this.subButton.UseVisualStyleBackColor = true;
            this.subButton.Click += new System.EventHandler(this.subButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nQStextBox);
            this.panel1.Controls.Add(this.hScrollBar);
            this.panel1.Controls.Add(this.dateTextBox);
            this.panel1.Controls.Add(this.nextButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.timeTextBox);
            this.panel1.Controls.Add(this.testNameTextBox);
            this.panel1.Controls.Add(this.nquesTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 422);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Number of Question in All Set";
            // 
            // nQStextBox
            // 
            this.nQStextBox.Location = new System.Drawing.Point(269, 278);
            this.nQStextBox.Name = "nQStextBox";
            this.nQStextBox.Size = new System.Drawing.Size(275, 20);
            this.nQStextBox.TabIndex = 18;
            this.nQStextBox.Text = "Enter Number of Question in All Set";
            this.nQStextBox.Click += new System.EventHandler(this.nQStextBox_Click);
            // 
            // hScrollBar
            // 
            this.hScrollBar.Location = new System.Drawing.Point(3, 409);
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(822, 10);
            this.hScrollBar.TabIndex = 7;
            this.hScrollBar.Value = 40;
            this.hScrollBar.Visible = false;
            this.hScrollBar.ValueChanged += new System.EventHandler(this.hScrollBar_ValueChanged);
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(268, 241);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(276, 20);
            this.dateTextBox.TabIndex = 17;
            this.dateTextBox.Text = "Enter Date of Test When You Want To Create";
            this.dateTextBox.Click += new System.EventHandler(this.dateTextBox_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextButton.BackgroundImage = global::Online_Classes.Properties.Resources.moreBut;
            this.nextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextButton.Location = new System.Drawing.Point(743, 159);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(64, 64);
            this.nextButton.TabIndex = 6;
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enter Test Name";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(268, 204);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(276, 20);
            this.timeTextBox.TabIndex = 16;
            this.timeTextBox.Text = "Enter Time Of Test";
            this.timeTextBox.Click += new System.EventHandler(this.timeTextBox_Click);
            // 
            // testNameTextBox
            // 
            this.testNameTextBox.Location = new System.Drawing.Point(268, 125);
            this.testNameTextBox.Name = "testNameTextBox";
            this.testNameTextBox.Size = new System.Drawing.Size(276, 20);
            this.testNameTextBox.TabIndex = 10;
            this.testNameTextBox.Text = "Enter Test Name";
            this.testNameTextBox.Click += new System.EventHandler(this.testNameTextBox_Click);
            // 
            // nquesTextBox
            // 
            this.nquesTextBox.Location = new System.Drawing.Point(268, 167);
            this.nquesTextBox.Name = "nquesTextBox";
            this.nquesTextBox.Size = new System.Drawing.Size(276, 20);
            this.nquesTextBox.TabIndex = 15;
            this.nquesTextBox.Text = "Enter Number Of Question  in a Set";
            this.nquesTextBox.Click += new System.EventHandler(this.nquesTextBox_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Number Of Question in a Set";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Enter Test Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Enter Duration Of Test";
            // 
            // myTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1370, 640);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "myTestForm";
            this.Text = "myTestForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox correctAnsTextBox;
        private System.Windows.Forms.TextBox opt4TextBox;
        private System.Windows.Forms.TextBox opt3TextBox;
        private System.Windows.Forms.TextBox opt1TextBox;
        private System.Windows.Forms.RichTextBox queRichTextBox;
        private System.Windows.Forms.Label enterQueLabel;
        private System.Windows.Forms.Label queRecordCounterLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label totalQueLabel;
        private System.Windows.Forms.Label nQuestionLabel;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.HScrollBar hScrollBar;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TextBox opt2TextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox nquesTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox testNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nQStextBox;

    }
}