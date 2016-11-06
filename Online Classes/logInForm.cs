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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            idTextBox.ForeColor = Color.Gray;
            idTextBox.Text = "Enter your Identification Serial";
            paswdTextBox.ForeColor = Color.Gray;
            paswdTextBox.Text = "Enter your Associated Password";
        }
        
        private void idTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            idTextBox.Clear();
            idTextBox.ForeColor = Color.Black;
        }

        private void paswdTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            paswdTextBox.Clear();
            paswdTextBox.ForeColor = Color.Black;
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
  
          
            string MyConString = "SERVER=localhost;" + "DATABASE=onlineclasses;" + "UID=root;" + "PASSWORD=root;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select fname,emailId,paswd,acntType from userdatarecord where emailId='" + idTextBox.Text + "' and paswd='" + paswdTextBox.Text + "'";

            int c = 0;
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                if (Reader["emailId"].ToString().Equals(idTextBox.Text) && Reader["paswd"].ToString().Equals(paswdTextBox.Text))
                {
                    c++;
                }
            }
            if (c > 0)
            {

                homeForm._homeForm.update(Reader["fname"].ToString());
                homeForm._homeForm.logInMailId(idTextBox.Text);

                myAccount ob = new myAccount();
                homeForm._homeForm.mainPanelFunction(ob);
                myAccount._uid.studStatus(Reader["acntType"].ToString());

            }
            else
            {
                MessageBox.Show("Try Again!", "Alert", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                idTextBox.ForeColor = Color.Gray;
                idTextBox.Text = "Enter your Identification Serial";

                paswdTextBox.ForeColor = Color.Gray;
                paswdTextBox.Text = "Enter your Associated Password";
 
            }
            connection.Close();
        }

        private void paswdTextBox_Enter(object sender, EventArgs e)
        {
            paswdTextBox.PasswordChar = '*';
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            signUpForm ob = new signUpForm();
            homeForm._homeForm.mainPanelFunction(ob);
        }

    }
}
