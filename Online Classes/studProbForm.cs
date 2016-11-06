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
    public partial class studProbForm : Form
    {
        Timer timer = new Timer();
        
        public studProbForm()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Interval = 60*5;
            timer.Enabled = true;            
     
        }

        public void s()
        {
            string MyConString = "SERVER=localhost;" + "DATABASE=onlineclasses;" + "UID=root;" + "PASSWORD=root;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select * from problem ORDER BY date desc;";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                queryRichTextBox.Text = queryRichTextBox.Text + Reader["sr"].ToString() + "  ( " + Reader["date"].ToString() + ") \n     " + Reader["name"].ToString() + ":-  " + Reader["prob"].ToString() + "  \n        " + Reader["reply"].ToString() + "\n\n";
            }
            connection.Close(); 
        
        }
        private void studProbForm_Load(object sender, EventArgs e)
        {
            nameTextBox.ForeColor = Color.Gray;
            nameTextBox.Text = "Enter Serial Id of Student:";
           
            replyRichTextBox.ForeColor = Color.Gray;
            replyRichTextBox.Text = "Solution:\n";
            s();      
        }

        private void nameTextBox_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            nameTextBox.ForeColor = Color.Black;
        }

        private void replyButton_Click(object sender, EventArgs e)
        {
            string MyConStringn = "SERVER=localhost;" + "DATABASE=onlineclasses;" + "UID=root;" + "PASSWORD=root;";
            MySqlConnection connectionn = new MySqlConnection(MyConStringn);
            MySqlCommand commandn = connectionn.CreateCommand();
            MySqlDataReader Readern;
            TextBox rply = new TextBox();
            rply.Visible = false;

            commandn.CommandText = "select * from problem where sr='"+nameTextBox.Text+"';";
            connectionn.Open();

            Readern = commandn.ExecuteReader();
            while (Readern.Read())
            {
                rply.Text = Readern["reply"].ToString();
            }
            connectionn.Close(); 


            string MyConString = "SERVER=localhost;" + "DATABASE=onlineclasses;" + "UID=root;" + "PASSWORD=root;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;

            rply.Text = rply.Text +"\n  "+ replyRichTextBox.Text;
            command.CommandText = "update problem set reply ='"+rply.Text+"' where sr="+nameTextBox.Text+";";
            connection.Open();

            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
            }

            connection.Close(); 
            MessageBox.Show("Replied");
            replyRichTextBox.Clear();
            nameTextBox.Clear();
            nameTextBox.ForeColor = Color.Gray;
            nameTextBox.Text = "Enter Serial Id of Student:";
            replyRichTextBox.Text = "Solution:\n";
        }

        private void replyRichTextBox_Click(object sender, EventArgs e)
        {
            replyRichTextBox.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            queryRichTextBox.Clear();
            s();
        }

        
    }
}
