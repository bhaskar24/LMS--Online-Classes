namespace Online_Classes
{
    partial class onlineTestForm
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
            this.subButton = new System.Windows.Forms.Button();
            this.timeGroupBox = new System.Windows.Forms.GroupBox();
            this.queRichTextBox = new System.Windows.Forms.RichTextBox();
            this.opt4RadioButton = new System.Windows.Forms.RadioButton();
            this.opt2RadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.opt1RadioButton = new System.Windows.Forms.RadioButton();
            this.opt3RadioButton = new System.Windows.Forms.RadioButton();
            this.queCounterLabel = new System.Windows.Forms.Label();
            this.nQueLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.min = new System.Windows.Forms.Label();
            this.secLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hr = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // subButton
            // 
            this.subButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.subButton.BackgroundImage = global::Online_Classes.Properties.Resources.moreBut;
            this.subButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.subButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.subButton.Location = new System.Drawing.Point(569, 414);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(60, 60);
            this.subButton.TabIndex = 0;
            this.subButton.UseVisualStyleBackColor = true;
            this.subButton.Click += new System.EventHandler(this.subButton_Click);
            // 
            // timeGroupBox
            // 
            this.timeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeGroupBox.AutoSize = true;
            this.timeGroupBox.Controls.Add(this.queRichTextBox);
            this.timeGroupBox.Controls.Add(this.opt4RadioButton);
            this.timeGroupBox.Controls.Add(this.opt2RadioButton);
            this.timeGroupBox.Controls.Add(this.label4);
            this.timeGroupBox.Controls.Add(this.opt1RadioButton);
            this.timeGroupBox.Controls.Add(this.opt3RadioButton);
            this.timeGroupBox.Controls.Add(this.queCounterLabel);
            this.timeGroupBox.Controls.Add(this.nQueLabel);
            this.timeGroupBox.Controls.Add(this.label2);
            this.timeGroupBox.Location = new System.Drawing.Point(32, 56);
            this.timeGroupBox.Name = "timeGroupBox";
            this.timeGroupBox.Size = new System.Drawing.Size(1106, 359);
            this.timeGroupBox.TabIndex = 4;
            this.timeGroupBox.TabStop = false;
            // 
            // queRichTextBox
            // 
            this.queRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.queRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.queRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queRichTextBox.Location = new System.Drawing.Point(321, 132);
            this.queRichTextBox.Name = "queRichTextBox";
            this.queRichTextBox.Size = new System.Drawing.Size(501, 166);
            this.queRichTextBox.TabIndex = 4;
            this.queRichTextBox.Text = "The number of integer n satisfying (- n + 2 >= 0 ) and ( 2n >= 4 ) is";
            // 
            // opt4RadioButton
            // 
            this.opt4RadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.opt4RadioButton.AutoSize = true;
            this.opt4RadioButton.Location = new System.Drawing.Point(828, 304);
            this.opt4RadioButton.Name = "opt4RadioButton";
            this.opt4RadioButton.Size = new System.Drawing.Size(74, 17);
            this.opt4RadioButton.TabIndex = 1;
            this.opt4RadioButton.TabStop = true;
            this.opt4RadioButton.Text = "4th Option";
            this.opt4RadioButton.UseVisualStyleBackColor = true;
            // 
            // opt2RadioButton
            // 
            this.opt2RadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.opt2RadioButton.AutoSize = true;
            this.opt2RadioButton.Location = new System.Drawing.Point(444, 304);
            this.opt2RadioButton.Name = "opt2RadioButton";
            this.opt2RadioButton.Size = new System.Drawing.Size(80, 17);
            this.opt2RadioButton.TabIndex = 1;
            this.opt2RadioButton.TabStop = true;
            this.opt2RadioButton.Text = "2nd Option ";
            this.opt2RadioButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(957, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total Question";
            // 
            // opt1RadioButton
            // 
            this.opt1RadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.opt1RadioButton.AutoSize = true;
            this.opt1RadioButton.Location = new System.Drawing.Point(239, 304);
            this.opt1RadioButton.Name = "opt1RadioButton";
            this.opt1RadioButton.Size = new System.Drawing.Size(76, 17);
            this.opt1RadioButton.TabIndex = 1;
            this.opt1RadioButton.TabStop = true;
            this.opt1RadioButton.Text = "1st Option ";
            this.opt1RadioButton.UseVisualStyleBackColor = true;
            // 
            // opt3RadioButton
            // 
            this.opt3RadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.opt3RadioButton.AutoSize = true;
            this.opt3RadioButton.Location = new System.Drawing.Point(646, 304);
            this.opt3RadioButton.Name = "opt3RadioButton";
            this.opt3RadioButton.Size = new System.Drawing.Size(72, 17);
            this.opt3RadioButton.TabIndex = 1;
            this.opt3RadioButton.TabStop = true;
            this.opt3RadioButton.Text = "3rd option";
            this.opt3RadioButton.UseVisualStyleBackColor = true;
            // 
            // queCounterLabel
            // 
            this.queCounterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.queCounterLabel.AutoSize = true;
            this.queCounterLabel.ForeColor = System.Drawing.Color.Gray;
            this.queCounterLabel.Location = new System.Drawing.Point(127, 58);
            this.queCounterLabel.Name = "queCounterLabel";
            this.queCounterLabel.Size = new System.Drawing.Size(19, 13);
            this.queCounterLabel.TabIndex = 2;
            this.queCounterLabel.Text = "00";
            // 
            // nQueLabel
            // 
            this.nQueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nQueLabel.AutoSize = true;
            this.nQueLabel.ForeColor = System.Drawing.Color.Gray;
            this.nQueLabel.Location = new System.Drawing.Point(1044, 58);
            this.nQueLabel.Name = "nQueLabel";
            this.nQueLabel.Size = new System.Drawing.Size(19, 13);
            this.nQueLabel.TabIndex = 2;
            this.nQueLabel.Text = "00";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(52, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Question No.";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.min);
            this.panel2.Controls.Add(this.secLabel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.timeGroupBox);
            this.panel2.Controls.Add(this.subButton);
            this.panel2.Controls.Add(this.hr);
            this.panel2.Location = new System.Drawing.Point(4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1175, 477);
            this.panel2.TabIndex = 4;
            // 
            // min
            // 
            this.min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.min.AutoSize = true;
            this.min.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.ForeColor = System.Drawing.SystemColors.Highlight;
            this.min.Location = new System.Drawing.Point(1000, 14);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(55, 39);
            this.min.TabIndex = 6;
            this.min.Text = "00";
            this.min.TextChanged += new System.EventHandler(this.min_TextChanged);
            // 
            // secLabel
            // 
            this.secLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.secLabel.AutoSize = true;
            this.secLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.secLabel.Location = new System.Drawing.Point(1062, 14);
            this.secLabel.Name = "secLabel";
            this.secLabel.Size = new System.Drawing.Size(55, 39);
            this.secLabel.TabIndex = 6;
            this.secLabel.Text = "00";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(1045, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 39);
            this.label7.TabIndex = 6;
            this.label7.Text = ":";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(985, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 39);
            this.label5.TabIndex = 6;
            this.label5.Text = ":";
            // 
            // hr
            // 
            this.hr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hr.AutoSize = true;
            this.hr.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hr.ForeColor = System.Drawing.SystemColors.Highlight;
            this.hr.Location = new System.Drawing.Point(939, 14);
            this.hr.Name = "hr";
            this.hr.Size = new System.Drawing.Size(55, 39);
            this.hr.TabIndex = 6;
            this.hr.Text = "00";
            this.hr.TextChanged += new System.EventHandler(this.min_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // onlineTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Online_Classes.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(1184, 485);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Name = "onlineTestForm";
            this.ShowInTaskbar = false;
            this.Text = "Online Test";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Deactivate += new System.EventHandler(this.onlineTestForm_Deactivate);
            this.Load += new System.EventHandler(this.onlineTestForm_Load);
            this.timeGroupBox.ResumeLayout(false);
            this.timeGroupBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.GroupBox timeGroupBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton opt4RadioButton;
        private System.Windows.Forms.RadioButton opt2RadioButton;
        private System.Windows.Forms.RadioButton opt1RadioButton;
        private System.Windows.Forms.RadioButton opt3RadioButton;
        private System.Windows.Forms.Label nQueLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label queCounterLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox queRichTextBox;
        private System.Windows.Forms.Label secLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label hr;

    }
}