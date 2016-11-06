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
    public partial class queriesForm : Form
    {
        Timer timer = new Timer();
    
        public queriesForm()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(timer1_Tick); // It better to do this whith double Tab Key
            timer.Interval = 60 * 2;
            timer.Enabled = true;            
            
        }
        public void rsltLoad()
        {
            soluRichTextBox.Clear();
            string MyConString = "SERVER=localhost;" + "DATABASE=onlineclasses;" + "UID=root;" + "PASSWORD=root;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
    
            command.CommandText = "select name,prob,reply from problem where reply IS NOT NULL ORDER BY date desc;";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                soluRichTextBox.Text += Reader["name"].ToString() + "\n  " + Reader["prob"].ToString() + Reader["reply"].ToString() + "\n";
    
            }
            connection.Close();
           
          }
        private void queriesForm_Load(object sender, EventArgs e)
        {
            nameTextBox.ForeColor = Color.Gray;
            nameTextBox.Text = "Enter Your Name";

            quariesRichTextBox.ForeColor = Color.Gray;
            soluRichTextBox.ForeColor = Color.Gray;
            rsltLoad();
        }
        public void s()
        {
            quariesRichTextBox.Clear();
            nameTextBox.Clear();
        }
       
        private void quariesRichTextBox_Click(object sender, EventArgs e)
        {
            quariesRichTextBox.Clear();
        }

        private void nameTextBox_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string MyConString = "SERVER=localhost;" + "DATABASE=onlineclasses;" + "UID=root;" + "PASSWORD=root;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            dlabel.Text = dateTimePicker.Value.ToShortDateString() + " " + dateTimePicker.Value.ToShortTimeString();
            command.CommandText = "insert into problem(date,name,prob)values('" + dlabel.Text + "','" + nameTextBox.Text + "','" + quariesRichTextBox.Text + "');";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
            }
            //s();
            connection.Close();
            MessageBox.Show("Your Query is Submitted.");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rsltLoad();
        }

    }
}
