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
using Microsoft.DirectX.AudioVideoPlayback;

namespace Online_Classes
{
    public partial class eventVideoForm : Form
    {
        private System.ComponentModel.Container components = null;

        public eventVideoForm()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.uiMode = "None";

        }
        public void vs()
        {
            pathTextBox.Visible = false;

            selectedValueTextBox.Visible = false;
            selectedValue2TextBox.Visible = false;
            videosListView.GridLines = false;
            string MyConString = "SERVER=localhost;" + "DATABASE=onlineclasses;" + "UID=root;" + "PASSWORD=root;";
            videosListView.Items.Clear();
     
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            string tab = myAccount._uid.uidReturnFun();
            command.CommandText = "select * from "+tab+";";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                videosListView.Items.Add(new ListViewItem(new[] { Reader["Sr"].ToString(), Reader["insName"].ToString(), Reader["topic"].ToString(), Reader["date"].ToString(), Reader["time"].ToString(), Reader["videoPath"].ToString() }));
            }

            connection.Close();
        
        }
        private void eventVideoForm_Load(object sender, EventArgs e)
        {
            vs();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            selectedValueTextBox.Text = videosListView.SelectedItems[0].SubItems[2].Text; //ins name
            selectedValue2TextBox.Text = videosListView.SelectedItems[0].SubItems[3].Text;//topic
            pathTextBox.Text = videosListView.SelectedItems[0].SubItems[5].Text;//path
            
            axWindowsMediaPlayer1.URL = pathTextBox.Text;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            vs();
        }

        private void fullScreenButton_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.fullScreen = true;
        }

        private void axWindowsMediaPlayer1_VisibleChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
     
        }   
    }
}
