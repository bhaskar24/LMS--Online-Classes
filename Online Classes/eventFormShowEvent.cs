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
    public partial class eventFormShowEvent : Form
    {
        public eventFormShowEvent()
        {
            InitializeComponent();
            styleText(); 
        }


        public void styleText()
        {
            evntDateTextBox.ForeColor = Color.Gray;
            evntDateTextBox.Text = "Select the Date";
            topicTextBox.ForeColor = Color.Gray;
            topicTextBox.Text = "Enter the Topic of Video";
       
        }
        private void showEventButton_Click(object sender, EventArgs e)
        {
            string MyConString = "SERVER=localhost;" + "DATABASE=onlineclasses;" + "UID=root;" + "PASSWORD=root;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;

            command.CommandText = "select Sr,insName,topic,date,time from eventdatarecord where topic='" + topicTextBox.Text + "' and date='"+evntDateTextBox.Text+"';";
            connection.Open();
            Reader = command.ExecuteReader();
            int c = 0;
            while (Reader.Read())
            {
                if (Reader["topic"].ToString().Equals(topicTextBox.Text) && Reader["date"].ToString().Equals(evntDateTextBox.Text))
                {
                    showEventListView.Items.Clear();
                    showEventListView.Items.Add(new ListViewItem(new[] { Reader["Sr"].ToString(), Reader["insName"].ToString(), Reader["topic"].ToString(), Reader["date"].ToString(), Reader["time"].ToString() }));
                }
                else
                {
                    MessageBox.Show("Unable to Find Query","Alert",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Warning);
                }
            }
            connection.Close(); 

        }

        private void topicTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            topicTextBox.Clear();
            topicTextBox.ForeColor = Color.Black;
        }

        private void evntDateTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            evntDateTextBox.Clear();
            evntDateTextBox.ForeColor = Color.Black;
        }

       
        private void evntDateTextBox_TextChanged(object sender, EventArgs e)
        {
            evntDateTextBox.Text = evntDateTimePicker.Value.ToShortDateString();
        }
        public void s()
        {
            string MyConString = "SERVER=localhost;" + "DATABASE=onlineclasses;" + "UID=root;" + "PASSWORD=root;";
            showEventListView.GridLines = false;
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;

            command.CommandText = "select * from eventdatarecord order by date desc;";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                showEventListView.Items.Add(new ListViewItem(new[] { Reader["Sr"].ToString(), Reader["insName"].ToString(), Reader["topic"].ToString(), Reader["date"].ToString(), Reader["time"].ToString() }));
            }

            connection.Close(); 

        }
        private void eventFormShowEvent_Load(object sender, EventArgs e)
        {
               s();        
        }

        private void evntDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            evntDateTextBox.Text = evntDateTimePicker.Value.ToShortDateString();
        }

        private void clrRecordsButton_Click(object sender, EventArgs e)
        {
            showEventListView.Items.Clear();
            styleText();
            s();
        }

    }
}
