namespace Online_Classes
{
    partial class homeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.homeHeaderPicBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashBoardLinkLabel = new System.Windows.Forms.LinkLabel();
            this.onlineTestLinkLabel = new System.Windows.Forms.LinkLabel();
            this.queriesLinkLabel = new System.Windows.Forms.LinkLabel();
            this.complainsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.aboutUsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.statusLinkLabel = new System.Windows.Forms.LinkLabel();
            this.loginIndicator = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.homeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.EBookLinkLabel = new System.Windows.Forms.LinkLabel();
            this.newsLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.homeHeaderPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2});
            this.shapeContainer2.Size = new System.Drawing.Size(1250, 626);
            this.shapeContainer2.TabIndex = 4;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 638;
            this.lineShape2.X2 = 639;
            this.lineShape2.Y1 = 168;
            this.lineShape2.Y2 = 508;
            // 
            // homeHeaderPicBox
            // 
            this.homeHeaderPicBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.homeHeaderPicBox.Location = new System.Drawing.Point(0, 46);
            this.homeHeaderPicBox.Name = "homeHeaderPicBox";
            this.homeHeaderPicBox.Size = new System.Drawing.Size(1250, 33);
            this.homeHeaderPicBox.TabIndex = 8;
            this.homeHeaderPicBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Online_Classes.Properties.Resources.ico;
            this.pictureBox1.Location = new System.Drawing.Point(99, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 70);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // dashBoardLinkLabel
            // 
            this.dashBoardLinkLabel.AutoSize = true;
            this.dashBoardLinkLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.dashBoardLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.dashBoardLinkLabel.Location = new System.Drawing.Point(613, 82);
            this.dashBoardLinkLabel.Name = "dashBoardLinkLabel";
            this.dashBoardLinkLabel.Size = new System.Drawing.Size(63, 13);
            this.dashBoardLinkLabel.TabIndex = 9;
            this.dashBoardLinkLabel.TabStop = true;
            this.dashBoardLinkLabel.Text = "Dash Board";
            this.dashBoardLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dashBoardLinkLabel_LinkClicked);
            // 
            // onlineTestLinkLabel
            // 
            this.onlineTestLinkLabel.AutoSize = true;
            this.onlineTestLinkLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.onlineTestLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.onlineTestLinkLabel.Location = new System.Drawing.Point(734, 82);
            this.onlineTestLinkLabel.Name = "onlineTestLinkLabel";
            this.onlineTestLinkLabel.Size = new System.Drawing.Size(61, 13);
            this.onlineTestLinkLabel.TabIndex = 9;
            this.onlineTestLinkLabel.TabStop = true;
            this.onlineTestLinkLabel.Text = "Online Test";
            this.onlineTestLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.onlineTestLinkLabel_LinkClicked);
            // 
            // queriesLinkLabel
            // 
            this.queriesLinkLabel.AutoSize = true;
            this.queriesLinkLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.queriesLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.queriesLinkLabel.Location = new System.Drawing.Point(842, 82);
            this.queriesLinkLabel.Name = "queriesLinkLabel";
            this.queriesLinkLabel.Size = new System.Drawing.Size(153, 13);
            this.queriesLinkLabel.TabIndex = 9;
            this.queriesLinkLabel.TabStop = true;
            this.queriesLinkLabel.Text = "Queries/Problems In Questions";
            this.queriesLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.queriesLinkLabel_LinkClicked);
            // 
            // complainsLinkLabel
            // 
            this.complainsLinkLabel.AutoSize = true;
            this.complainsLinkLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.complainsLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.complainsLinkLabel.Location = new System.Drawing.Point(1000, 82);
            this.complainsLinkLabel.Name = "complainsLinkLabel";
            this.complainsLinkLabel.Size = new System.Drawing.Size(55, 13);
            this.complainsLinkLabel.TabIndex = 9;
            this.complainsLinkLabel.TabStop = true;
            this.complainsLinkLabel.Text = "Complains";
            this.complainsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.complainsLinkLabel_LinkClicked);
            // 
            // aboutUsLinkLabel
            // 
            this.aboutUsLinkLabel.AutoSize = true;
            this.aboutUsLinkLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.aboutUsLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.aboutUsLinkLabel.Location = new System.Drawing.Point(1065, 82);
            this.aboutUsLinkLabel.Name = "aboutUsLinkLabel";
            this.aboutUsLinkLabel.Size = new System.Drawing.Size(51, 13);
            this.aboutUsLinkLabel.TabIndex = 9;
            this.aboutUsLinkLabel.TabStop = true;
            this.aboutUsLinkLabel.Text = "About Us";
            this.aboutUsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutUsLinkLabel_LinkClicked);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(1074, 27);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(55, 13);
            this.welcomeLabel.TabIndex = 11;
            this.welcomeLabel.Text = "Welcome,";
            // 
            // statusLinkLabel
            // 
            this.statusLinkLabel.ActiveLinkColor = System.Drawing.Color.Black;
            this.statusLinkLabel.AutoSize = true;
            this.statusLinkLabel.Location = new System.Drawing.Point(1185, 27);
            this.statusLinkLabel.Name = "statusLinkLabel";
            this.statusLinkLabel.Size = new System.Drawing.Size(43, 13);
            this.statusLinkLabel.TabIndex = 15;
            this.statusLinkLabel.TabStop = true;
            this.statusLinkLabel.Text = "Sign  In";
            this.statusLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.statusLinkLabel_LinkClicked);
            // 
            // loginIndicator
            // 
            this.loginIndicator.AutoSize = true;
            this.loginIndicator.Location = new System.Drawing.Point(1124, 27);
            this.loginIndicator.Name = "loginIndicator";
            this.loginIndicator.Size = new System.Drawing.Size(38, 13);
            this.loginIndicator.TabIndex = 11;
            this.loginIndicator.Text = "Guest,";
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.CausesValidation = false;
            this.mainPanel.Location = new System.Drawing.Point(29, 107);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1190, 486);
            this.mainPanel.TabIndex = 13;
            this.mainPanel.TabStop = true;
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Location = new System.Drawing.Point(1038, 604);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(35, 13);
            this.dateTimeLabel.TabIndex = 16;
            this.dateTimeLabel.Text = "label7";
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(258, 46);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(100, 20);
            this.mailTextBox.TabIndex = 17;
            // 
            // homeLinkLabel
            // 
            this.homeLinkLabel.AutoSize = true;
            this.homeLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.homeLinkLabel.Location = new System.Drawing.Point(572, 82);
            this.homeLinkLabel.Name = "homeLinkLabel";
            this.homeLinkLabel.Size = new System.Drawing.Size(35, 13);
            this.homeLinkLabel.TabIndex = 18;
            this.homeLinkLabel.TabStop = true;
            this.homeLinkLabel.Text = "Home";
            this.homeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.homeLinkLabel_LinkClicked);
            // 
            // EBookLinkLabel
            // 
            this.EBookLinkLabel.AutoSize = true;
            this.EBookLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.EBookLinkLabel.Location = new System.Drawing.Point(680, 82);
            this.EBookLinkLabel.Name = "EBookLinkLabel";
            this.EBookLinkLabel.Size = new System.Drawing.Size(47, 13);
            this.EBookLinkLabel.TabIndex = 19;
            this.EBookLinkLabel.TabStop = true;
            this.EBookLinkLabel.Text = "E-Books";
            this.EBookLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EBooklinkLabel_LinkClicked);
            // 
            // newsLinkLabel
            // 
            this.newsLinkLabel.AutoSize = true;
            this.newsLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.newsLinkLabel.Location = new System.Drawing.Point(801, 82);
            this.newsLinkLabel.Name = "newsLinkLabel";
            this.newsLinkLabel.Size = new System.Drawing.Size(34, 13);
            this.newsLinkLabel.TabIndex = 20;
            this.newsLinkLabel.TabStop = true;
            this.newsLinkLabel.Text = "News";
            this.newsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newsLinkLabel_LinkClicked);
            // 
            // homeForm
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Online_Classes.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(1250, 626);
            this.Controls.Add(this.newsLinkLabel);
            this.Controls.Add(this.EBookLinkLabel);
            this.Controls.Add(this.homeLinkLabel);
            this.Controls.Add(this.dateTimeLabel);
            this.Controls.Add(this.loginIndicator);
            this.Controls.Add(this.statusLinkLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.aboutUsLinkLabel);
            this.Controls.Add(this.complainsLinkLabel);
            this.Controls.Add(this.queriesLinkLabel);
            this.Controls.Add(this.onlineTestLinkLabel);
            this.Controls.Add(this.dashBoardLinkLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.homeHeaderPicBox);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.mainPanel);
            this.Name = "homeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Online Classes";
            this.Load += new System.EventHandler(this.homeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.homeHeaderPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       /* private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        */private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.PictureBox homeHeaderPicBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel dashBoardLinkLabel;
        private System.Windows.Forms.LinkLabel onlineTestLinkLabel;
        private System.Windows.Forms.LinkLabel queriesLinkLabel;
        private System.Windows.Forms.LinkLabel complainsLinkLabel;
        private System.Windows.Forms.LinkLabel aboutUsLinkLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.LinkLabel statusLinkLabel;
        private System.Windows.Forms.Label loginIndicator;

        public System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.LinkLabel homeLinkLabel;
        private System.Windows.Forms.LinkLabel EBookLinkLabel;
        private System.Windows.Forms.LinkLabel newsLinkLabel;
    }
}

