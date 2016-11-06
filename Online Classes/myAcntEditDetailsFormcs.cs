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
    public partial class myAcntEditDetailsFormcs : Form
    {
        public myAcntEditDetailsFormcs()
        {
            InitializeComponent();
            passwdTextBox.ForeColor = Color.Gray;
            countryListBox.ForeColor = Color.Gray;
            acntTypeListBox.ForeColor = Color.Gray;
            
        }

        public void s()
        {
            TextBox tempTextBox = new TextBox();
            TextBox temp1TextBox= new TextBox();
            tempTextBox.Text=homeForm._homeForm.nameLabel();
            temp1TextBox.Text = homeForm._homeForm.mailID();
            string MyConString = "SERVER=localhost;" + "DATABASE=onlineclasses;" + "UID=root;" + "PASSWORD=root;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;

            command.CommandText = "select * from userdatarecord where fname='"+tempTextBox.Text+"' and emailId='"+temp1TextBox.Text+"';";
            connection.Open();
            Reader = command.ExecuteReader();
            while(Reader.Read())
            { 
                passwdTextBox.Text = Reader["paswd"].ToString();
                countryListBox.Text = Reader["country"].ToString();
                acntTypeListBox.Text = Reader["acntType"].ToString();
                
            }
            connection.Close();
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            s();
        }

        private void myAcntEditDetailsFormcs_Load(object sender, EventArgs e)
        {
            s();
        }
    }
}
