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
    public partial class testRegisForm : Form
    {
        public testRegisForm()
        {   
            InitializeComponent();
            _testRegisForm = this;
        }
        public static testRegisForm _testRegisForm;

        public string uID()
        {
            return uIdTextBox.Text;
        }
        public void testTime()
        {
            string testName = showTestForm._showTestForm.testName();
          
            string MyConString = "SERVER=localhost;" + "DATABASE=studenttest;" + "UID=root;" + "PASSWORD=root;";
        
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select * from " + testName + " where sr=1;";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                testnLabel.Text = Reader["duration"].ToString();
            }

            connection.Close();
        
        }
        private void testRegisForm_Load(object sender, EventArgs e)
        {
            testTime();
            if (homeForm._homeForm.status().Equals("Sign Out"))
            {
                uIdTextBox.ForeColor = Color.Gray;
                uIdTextBox.Text = "Enter Your Unique Id";
         
                //uIdTextBox.Text = myAccount._uid.uidReturnFun();
            }
            else 
            {
                uIdTextBox.ForeColor = Color.Gray;
                uIdTextBox.Text = "Enter Your Unique Id";
            }
            tnTextBox.ForeColor = Color.Gray;
            tnTextBox.Text = showTestForm._showTestForm.testName();
            //testnLabel.Text = uID();
        }

        public int checkId()
        {
            int st=0,c=0;

            string MyConString = "SERVER=localhost;" + "DATABASE=onlineclasses;" + "UID=root;" + "PASSWORD=root;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "show tables";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                if (Reader["Tables_in_onlineclasses"].ToString().Equals(uIdTextBox.Text))
                {
                    c++;
                }
            }

            connection.Close();
            if (c > 0)
            {
                st = 1;
            }
            return st;
        }
        public int checkTable()
        {
            int st = 0,c=0;

            string MyConString = "SERVER=localhost;" + "DATABASE=studenttestrecord;" + "UID=root;" + "PASSWORD=root;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "show tables";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                if (Reader["Tables_in_studenttestrecord"].ToString().Equals(uIdTextBox.Text))
                {
                    c++;
                }
            }

            connection.Close();
            if (c > 0)
            {
                st = 1;
            }
           
            return st;
        }

        private void uIdTextBox_Enter(object sender, EventArgs e)
        {
            uIdTextBox.Clear();
        }

        private void startTestButton_Click(object sender, EventArgs e)
        {
            if (uIdTextBox.Text.Equals("Enter Your Unique Id"))
            {
                MessageBox.Show("Enter Unique Id","Alert",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Warning);
            }
            else if(checkTable()==1)
            {
                onlineTestForm ob = new onlineTestForm();
                ob.Show();
            }
            else
            {
                string MyConString = "SERVER=localhost;" + "DATABASE=studenttestrecord;" + "UID=root;" + "PASSWORD=root;";
                string i = uIdTextBox.Text;
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
            //    string h = i;
                command.CommandText = "CREATE TABLE "+i+" (sr INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,testName VARCHAR(255),duration VARCHAR(45),date VARCHAR(45),maxMarks VARCHAR(45),obtainMarks VARCHAR(45),status VARCHAR(45),PRIMARY KEY (sr));"; 
                connection.Open();
                Reader = command.ExecuteReader();
                while (Reader.Read())
                 {

                 }

                connection.Close();
                onlineTestForm ob2 = new onlineTestForm();
                ob2.Show();
            }

        }

        private void uIdTextBox_Validating(object sender, CancelEventArgs e)
        {
            int a = checkId();
            if (a == 0)
            {
                MessageBox.Show("Invalid Unique Id!","Alert",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Warning);
                uIdTextBox.ForeColor = Color.Gray;
                uIdTextBox.Text = "Enter Your Unique Id";
            }
         
        }
    }
}
