using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Online_Classes
{
    public partial class myTestForm : Form
    {
        int c =1,n;
        public myTestForm()
        {
            InitializeComponent();

            enterQueLabel.ForeColor = Color.Gray;
            queRecordCounterLabel.ForeColor = Color.Gray;
            totalQueLabel.ForeColor = Color.Gray;
            nQuestionLabel.ForeColor=Color.Gray;
            testNameTextBox.ForeColor = Color.Gray;
            nquesTextBox.ForeColor = Color.Gray;
            timeTextBox.ForeColor = Color.Gray;
            dateTextBox.ForeColor = Color.Gray;
            opt1TextBox.ForeColor = Color.Gray;
            opt2TextBox.ForeColor = Color.Gray;
            opt3TextBox.ForeColor = Color.Gray;
            opt4TextBox.ForeColor = Color.Gray;
            correctAnsTextBox.ForeColor = Color.Gray;
            nQStextBox.ForeColor = Color.Gray;
        }

        private void hScrollBar_ValueChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
           
            panel1.Visible = false;
            panel2.Location = new Point(1,0);

            
            enterQueLabel.Location = new Point(11, 35);
            queRecordCounterLabel.Location = new Point(73, 35);

            totalQueLabel.Location = new Point(620,35);
            nQuestionLabel.Location = new Point(753,35);

            queRichTextBox.Location = new Point(11,107);
            queRichTextBox.Size = new Size(407, 205);
            opt1TextBox.Location = new Point(424,124);
            opt2TextBox.Location = new Point(424,150);
            opt3TextBox.Location = new Point(424,176);
            opt4TextBox.Location = new Point(424,202);
            correctAnsTextBox.Location = new Point(424,273);

            subButton.Location = new Point(743, 159);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            hScrollBar.Value = 100;
            string tablea = testNameTextBox.Text;
                       
            string MyConStringAcnt = "SERVER=localhost;" + "DATABASE=studenttest;" + "UID=root;" + "PASSWORD=root;";
            MySqlConnection connectionAcnt = new MySqlConnection(MyConStringAcnt);
            MySqlCommand commandAcnt = connectionAcnt.CreateCommand();
            MySqlDataReader ReaderAcnt;

            commandAcnt.CommandText = "CREATE TABLE " + tablea + "(sr INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,emailId VARCHAR(145) NOT NULL,noOfQues VARCHAR(255) NOT NULL,duration VARCHAR(45) NOT NULL,onDate VARCHAR(45) NOT NULL,question TEXT NOT NULL,opt1 VARCHAR(255) NOT NULL,opt2 VARCHAR(255) NOT NULL,opt3 VARCHAR(255) NOT NULL,opt4 VARCHAR(255) NOT NULL,correctOpt VARCHAR(255) NOT NULL,nAllSet VARCHAR(255),PRIMARY KEY (sr));";
            
            connectionAcnt.Open();
            ReaderAcnt = commandAcnt.ExecuteReader();
            connectionAcnt.Close();
            
            nQuestionLabel.Text = nquesTextBox.Text;
            n = int.Parse(nQStextBox.Text);
            queRecordCounterLabel.Text = (c)+"";

        }

        private void subButton_Click(object sender, EventArgs e)
        {
            if (c<=n )
            {
                string MyConStringAcnt = "SERVER=localhost;" + "DATABASE=studenttest;" + "UID=root;" + "PASSWORD=root;";
                MySqlConnection connectionAcnt = new MySqlConnection(MyConStringAcnt);
                MySqlCommand commandAcnt = connectionAcnt.CreateCommand();
                MySqlDataReader ReaderAcnt;
                string s;
                s = myAccount._uid.uidEmailId();
                string table = testNameTextBox.Text;
                commandAcnt.CommandText = "INSERT INTO " + table + " (emailId,noOfQues,duration,onDate,question,opt1,opt2,opt3,opt4,correctOpt,nAllSet)values('" + s + "','" + nquesTextBox.Text + "','" + timeTextBox.Text + "','" + dateTextBox.Text + "','" + queRichTextBox.Text + "','" + opt1TextBox.Text + "','" + opt2TextBox.Text + "','" + opt3TextBox.Text + "','" + opt4TextBox.Text + "','" + correctAnsTextBox.Text + "','"+nQStextBox.Text+"');";

                connectionAcnt.Open();
                ReaderAcnt = commandAcnt.ExecuteReader();
                while (ReaderAcnt.Read())
                { }

                connectionAcnt.Close();
                queRichTextBox.Clear();
                opt1TextBox.Clear();
                opt1TextBox.Text = "Enter 1st option";
                opt2TextBox.Clear();
                opt2TextBox.Text = "Enter 2nd option";
                opt3TextBox.Clear();
                opt3TextBox.Text = "Enter 3rd option";
                opt4TextBox.Clear();
                opt4TextBox.Text="Enter 4th option";
                correctAnsTextBox.Clear();
                correctAnsTextBox.Text="Enter Correct Answer";
                queRecordCounterLabel.Text = c + "";
                c++;
            }
            else
            {
                myAccount ob = new myAccount();
                homeForm._homeForm.mainPanelFunction(ob);
            }
        }

        private void testNameTextBox_Click(object sender, EventArgs e)
        {
            testNameTextBox.Clear();
            testNameTextBox.ForeColor = Color.Black;
        }

        private void nquesTextBox_Click(object sender, EventArgs e)
        {
            nquesTextBox.Clear();
            nquesTextBox.ForeColor = Color.Black;
        }

        private void timeTextBox_Click(object sender, EventArgs e)
        {
            timeTextBox.Clear();
            timeTextBox.ForeColor = Color.Black;
        }

        private void dateTextBox_Click(object sender, EventArgs e)
        {
            dateTextBox.Clear();
            dateTextBox.ForeColor = Color.Black;
        }

        private void opt1TextBox_Click(object sender, EventArgs e)
        {
            opt1TextBox.Clear();
            opt1TextBox.ForeColor = Color.Black;
        }

        private void opt2TextBox_Click(object sender, EventArgs e)
        {
            opt2TextBox.Clear();
            opt2TextBox.ForeColor = Color.Black;
            
        }

        private void opt3TextBox_Click(object sender, EventArgs e)
        {
            opt3TextBox.Clear();
            opt3TextBox.ForeColor = Color.Black;
        
        }

        private void opt4TextBox_Click(object sender, EventArgs e)
        {
            opt4TextBox.Clear();
            opt4TextBox.ForeColor = Color.Black;
        
        }

        private void correctAnsTextBox_Click(object sender, EventArgs e)
        {
            correctAnsTextBox.Clear();
            correctAnsTextBox.ForeColor = Color.Black;
        }

        private void queRichTextBox_Click(object sender, EventArgs e)
        {
            queRichTextBox.Clear();
            queRichTextBox.ForeColor = Color.Black;
        }

        private void nQStextBox_Click(object sender, EventArgs e)
        {
            nQStextBox.Clear();
            nQStextBox.ForeColor = Color.Gray;
        }

     
    }
}
