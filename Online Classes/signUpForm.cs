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
    public partial class signUpForm : Form
    {
        public signUpForm()
        {
            InitializeComponent();
            makeTextFieldGrey();
        }
        public static signUpForm _signUpForm;
        public void pauseVideo()
        {
           // axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
        public void makeTextFieldGrey()
        {
            fNameTextBox.ForeColor = Color.Gray;
            fNameTextBox.Text = "First Name";
            LNameTextBox.ForeColor = Color.Gray;
            LNameTextBox.Text = "Last Name";
            emailIdTextBox.ForeColor = Color.Gray;
            emailIdTextBox.Text = "Your email address";
            passwdTextBox.ForeColor = Color.Gray;
            numberTextBox.ForeColor = Color.Gray;
            numberTextBox.Text = "Your contact number without Country Code";
            countryListBox.ForeColor = Color.Gray;
            countryListBox.Text = "[Select]";
            acntTypeListBox.ForeColor = Color.Gray;
            acntTypeListBox.Text = "[Select]";
    
        }

        private void clearEntry()
        {
            fNameTextBox.Text = "";
            LNameTextBox.Text = "";
            emailIdTextBox.Text = "";
            passwdTextBox.Text = "";
            countryListBox.Text = "[Select]";
            numberTextBox.Text = "";
            acntTypeListBox.Text = "[Select]";
        }
     
        public void mkeAcnt(string id)
        {
            string MyConStringAcnt = "SERVER=localhost;" + "DATABASE=onlineclasses;" + "UID=root;" + "PASSWORD=root;";
            MySqlConnection connectionAcnt = new MySqlConnection(MyConStringAcnt);
            MySqlCommand commandAcnt = connectionAcnt.CreateCommand();
            MySqlDataReader ReaderAcnt;

            commandAcnt.CommandText = "CREATE TABLE " + id + "(Sr INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,insName VARCHAR(145),topic VARCHAR(200),date VARCHAR(45),time VARCHAR(45),videoPath VARCHAR(200),PRIMARY KEY (Sr),UNIQUE KEY(topic));";
            connectionAcnt.Open();
            ReaderAcnt = commandAcnt.ExecuteReader();
            connectionAcnt.Close();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            string id = fNameTextBox.Text + numberTextBox.Text;
            string MyConString = "SERVER=localhost;" + "DATABASE=onlineclasses;" + "UID=root;" + "PASSWORD=root;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
           
            command.CommandText = "insert into userdatarecord(fname,lname,emailId,paswd,country,cntctNumber,acntType) values('" + fNameTextBox.Text + "','" + LNameTextBox.Text + "','" + emailIdTextBox.Text + "','" + passwdTextBox.Text + "','" + countryListBox.SelectedItem.ToString() + "','" + numberTextBox.Text + "','" + acntTypeListBox.SelectedItem.ToString() + "');";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                         
            }
            homeForm._homeForm.update(fNameTextBox.Text);
            homeForm._homeForm.logInMailId(emailIdTextBox.Text);
            //clearEntry();
            makeTextFieldGrey();
            connection.Close();

            mkeAcnt(id);

            MessageBox.Show("Registration is Successfull");
            myAccount ob = new myAccount();
            homeForm._homeForm.mainPanelFunction(ob);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            makeTextFieldGrey();
        }


        private void fNameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            fNameTextBox.Clear();
            fNameTextBox.ForeColor = Color.Black;
        }

        private void LNameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            LNameTextBox.Clear();
            LNameTextBox.ForeColor = Color.Black;
        }

        private void emailIdTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            emailIdTextBox.Clear();
            emailIdTextBox.ForeColor = Color.Black;
        }


        private void numberTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            numberTextBox.Clear();
            numberTextBox.ForeColor = Color.Black;
        }

        private void passwdTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            passwdTextBox.Clear();
            passwdTextBox.ForeColor = Color.Black;
        }


     
        private void passwdTextBox_Enter(object sender, EventArgs e)
        {
            passwdTextBox.PasswordChar = '*';
        }

        private void countryListBox_DropDown(object sender, EventArgs e)
        {
            countryListBox.ForeColor = Color.Black;
     
        }

        private void acntTypeListBox_DropDown(object sender, EventArgs e)
        {
            acntTypeListBox.ForeColor = Color.Black;
        }

        private void emailIdTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (emailIdTextBox.Text.Contains("@") && emailIdTextBox.Text.Contains("."))
            {
                this.emailIdTextBox.Text = emailIdTextBox.Text;
            }
            else
            {
                MessageBox.Show("Wrong Email ID","Alert",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Warning);
                makeTextFieldGrey();
            }
        }

        private void signUpForm_Load(object sender, EventArgs e)
        {
            // axWindowsMediaPlayer1.Ctlcontrols.play();
        }

     
    }
}
