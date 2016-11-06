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
using System.IO;

namespace Online_Classes
{
    public partial class manageEventsForm : Form
    {
        string tab = myAccount._uid.uidReturnFun();
   
        public manageEventsForm()
        {
            InitializeComponent();
        }
        public void vs()
        {
            videosListView.GridLines = false;
            string MyConString = "SERVER=localhost;" + "DATABASE=onlineclasses;" + "UID=root;" + "PASSWORD=root;";
            videosListView.Items.Clear();

            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            
            command.CommandText = "select * from " + tab + ";";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                videosListView.Items.Add(new ListViewItem(new[] { Reader["Sr"].ToString(), Reader["insName"].ToString(), Reader["topic"].ToString(), Reader["date"].ToString(), Reader["time"].ToString(), Reader["videoPath"].ToString() }));
            }

            connection.Close();

        }

        private void manageEventsForm_Load(object sender, EventArgs e)
        {
            vs();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            TextBox selectedValue2TextBox = new TextBox();
            TextBox pathTextBox = new TextBox();
            
            selectedValue2TextBox.Text = videosListView.SelectedItems[0].SubItems[2].Text;//topic
            pathTextBox.Text = videosListView.SelectedItems[0].SubItems[5].Text;//path
            MessageBox.Show(selectedValue2TextBox.Text);
            MessageBox.Show(pathTextBox.Text);
            string MyConString = "SERVER=localhost;" + "DATABASE=onlineclasses;" + "UID=root;" + "PASSWORD=root;";
            videosListView.Items.Clear();

            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            
            command.CommandText = "DELETE from "+tab+" where topic='"+selectedValue2TextBox.Text+"';";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
            }
            string d = myAccount._uid.uidReturnFun();
         
            string p = "C:\\video\\"+d+"\\"+ selectedValue2TextBox.Text + ".mp4";
            string t = "";
            for (int i = 0; i < p.Length; i++)
            {
                if (p.ElementAt(i).Equals('\\'))
                {
                    t = t + '\\' + p.ElementAt(i);
                }
                else { t = t + p.ElementAt(i); }
            }
            
            File.Delete(t);
            connection.Close();
            videosListView.Items.Clear();
            vs();
        }

    }
}
