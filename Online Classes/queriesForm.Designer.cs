namespace Online_Classes
{
    partial class queriesForm
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
            this.quariesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dlabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.soluRichTextBox = new System.Windows.Forms.RichTextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // quariesRichTextBox
            // 
            this.quariesRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quariesRichTextBox.Location = new System.Drawing.Point(6, 15);
            this.quariesRichTextBox.Name = "quariesRichTextBox";
            this.quariesRichTextBox.Size = new System.Drawing.Size(438, 256);
            this.quariesRichTextBox.TabIndex = 0;
            this.quariesRichTextBox.Text = "";
            this.quariesRichTextBox.Click += new System.EventHandler(this.quariesRichTextBox_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.quariesRichTextBox);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.dlabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(100, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 278);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Your Query";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(91, 72);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker.TabIndex = 3;
            // 
            // dlabel
            // 
            this.dlabel.AutoSize = true;
            this.dlabel.Location = new System.Drawing.Point(61, 47);
            this.dlabel.Name = "dlabel";
            this.dlabel.Size = new System.Drawing.Size(18, 17);
            this.dlabel.TabIndex = 4;
            this.dlabel.Text = "\"\"";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.soluRichTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(649, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 278);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Your Solved Query";
            // 
            // soluRichTextBox
            // 
            this.soluRichTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.soluRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.soluRichTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.soluRichTextBox.Location = new System.Drawing.Point(6, 16);
            this.soluRichTextBox.Name = "soluRichTextBox";
            this.soluRichTextBox.ReadOnly = true;
            this.soluRichTextBox.Size = new System.Drawing.Size(438, 256);
            this.soluRichTextBox.TabIndex = 12;
            this.soluRichTextBox.Text = "";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1164, 481);
            this.shapeContainer1.TabIndex = 12;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 600;
            this.lineShape1.X2 = 602;
            this.lineShape1.Y1 = 76;
            this.lineShape1.Y2 = 401;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(453, 425);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(215, 20);
            this.nameTextBox.TabIndex = 13;
            this.nameTextBox.Click += new System.EventHandler(this.nameTextBox_Click);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Location = new System.Drawing.Point(674, 423);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(136, 23);
            this.submitButton.TabIndex = 14;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // queriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Online_Classes.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(1164, 481);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "queriesForm";
            this.Text = "Queries/Problems In Questions";
            this.Load += new System.EventHandler(this.queriesForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox quariesRichTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox soluRichTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label dlabel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Timer timer1;

    }
}