namespace Online_Classes
{
    partial class LogInForm
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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.paswdTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logInbutton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(768, 180);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(223, 20);
            this.idTextBox.TabIndex = 1;
            this.idTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.idTextBox_MouseClick);
            // 
            // paswdTextBox
            // 
            this.paswdTextBox.Location = new System.Drawing.Point(768, 218);
            this.paswdTextBox.Name = "paswdTextBox";
            this.paswdTextBox.Size = new System.Drawing.Size(223, 20);
            this.paswdTextBox.TabIndex = 2;
            this.paswdTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paswdTextBox_MouseClick);
            this.paswdTextBox.Enter += new System.EventHandler(this.paswdTextBox_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Online_Classes.Properties.Resources.online_classes;
            this.pictureBox1.Location = new System.Drawing.Point(229, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // logInbutton
            // 
            this.logInbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInbutton.Location = new System.Drawing.Point(916, 254);
            this.logInbutton.Name = "logInbutton";
            this.logInbutton.Size = new System.Drawing.Size(75, 23);
            this.logInbutton.TabIndex = 3;
            this.logInbutton.Text = "Log In";
            this.logInbutton.UseVisualStyleBackColor = true;
            this.logInbutton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(835, 254);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Online_Classes.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(1245, 480);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.logInbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.paswdTextBox);
            this.Controls.Add(this.idTextBox);
            this.Name = "LogInForm";
            this.Text = "Online Classes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox paswdTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logInbutton;
        private System.Windows.Forms.Button exitButton;
    }
}