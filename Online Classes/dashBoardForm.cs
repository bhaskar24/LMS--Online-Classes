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
    public partial class dashBoardForm : Form
    {
        public dashBoardForm()
        {
            InitializeComponent();
        }

        public void dashContentHide(bool f)
        {
            classOfferedLabel.Visible = f;
            lineShape1.Visible = f;
            allEventsDetailListView.Visible = f;
        }

        public void s()
        {
            allEventsDetailListView.Items.Clear(); 
            allEventsDetailListView.GridLines = false;
            string MyConString = "SERVER=localhost;" + "DATABASE=onlineclasses;" + "UID=root;" + "PASSWORD=root;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;

            command.CommandText = "select * from eventdatarecord order by date desc;";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                allEventsDetailListView.Items.Add(new ListViewItem(new[] { Reader["Sr"].ToString(), Reader["insName"].ToString(), Reader["topic"].ToString(), Reader["date"].ToString(), Reader["time"].ToString() }));
            }

            connection.Close(); 

        }
        private void dashBoardForm_Load(object sender, EventArgs e)
        {
            searchFieldTextBox.ForeColor = Color.Gray;
            searchFieldTextBox.Text = "Enter the Topic you want to search";
            s();         
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            allEventsDetailListView.Items.Clear();
            allEventsDetailListView.GridLines = false;
            string MyConString = "SERVER=localhost;" + "DATABASE=onlineclasses;" + "UID=root;" + "PASSWORD=root;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;

            command.CommandText = "select * from eventdatarecord where topic='"+searchFieldTextBox.Text+"';";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                allEventsDetailListView.Items.Add(new ListViewItem(new[] { Reader["Sr"].ToString(), Reader["insName"].ToString(), Reader["topic"].ToString(), Reader["date"].ToString(), Reader["time"].ToString() }));
            }

            connection.Close(); 

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            searchFieldTextBox.ForeColor = Color.Gray;
            searchFieldTextBox.Text = "Enter the Topic you want to search";
  
            s();
        }

        private void searchFieldTextBox_Click(object sender, EventArgs e)
        {
            searchFieldTextBox.Clear();
   
        }

    }
}
