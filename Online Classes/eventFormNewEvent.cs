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
using System.Net;

namespace Online_Classes
{
    public partial class eventFormNewEvent : Form
    {
        string ftpServerIP;
        public eventFormNewEvent()
        {
            InitializeComponent();
            styletext();
        }
        public void styletext()
        {
            idTextBox.ForeColor = Color.Gray;
            topicTextBox.ForeColor = Color.Gray;
        
            if (homeForm._homeForm.status().Equals("Sign Out"))
            {
                idTextBox.Text = myAccount._uid.uidEmailId();
            }
            else
            {
                idTextBox.Text = "Enter your Identification";
            }
            insTextBox.Text = "Enter Institute/College Name";   
            insTextBox.ForeColor = Color.Gray;
            topicTextBox.Text = "Enter Topic of Event";
            dateTextBox.ForeColor = Color.Gray;
            dateTextBox.Text = DateTime.Now.ToShortDateString();
            timeTextBox.ForeColor = Color.Gray;
            timeTextBox.Text = DateTime.Now.ToShortTimeString();
            s();
            pathTextBox.Visible = false;
        
        }
        public void Upload(string uploadDb)
        {
            FileInfo fileInf = new FileInfo(uploadDb);
            string uri = "ftp://" + ftpServerIP + "/" + fileInf.Name;
            FtpWebRequest reqFTP;

            reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP) + "/" + fileInf.Name);
            reqFTP.KeepAlive = false;
            reqFTP.Method = WebRequestMethods.Ftp.UploadFile;
            reqFTP.UseBinary = true;
            reqFTP.ContentLength = fileInf.Length;
            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            int contentLen;

            FileStream fs = fileInf.OpenRead();
            try
            {
                Stream strm = reqFTP.GetRequestStream();
                contentLen = fs.Read(buff, 0, buffLength);

                while (contentLen != 0)
                {
                    strm.Write(buff, 0, contentLen);
                    contentLen = fs.Read(buff, 0, buffLength);
                }
                strm.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Upload Error");
            }

        }
        
        public void s()
        {
            showEventListView.Items.Clear();
            string MyConString = "SERVER=localhost;" + "DATABASE=onlineclasses;" + "UID=root;" + "PASSWORD=root;";
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
        
        public void contentClear()
        {
            idTextBox.Clear();
            insTextBox.Clear();
            topicTextBox.Clear();
        }
        private void idTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            idTextBox.Clear();
            idTextBox.ForeColor = Color.Black;
        }

        private void insTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            insTextBox.Clear();
            insTextBox.ForeColor = Color.Black;
        }

        private void topicTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            topicTextBox.Clear();
            topicTextBox.ForeColor = Color.Black;
        }

        private void Rename(string currentFilename, string newFilename)
        {
            FtpWebRequest reqFTP;
            try
            {
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + currentFilename));
                reqFTP.Method = WebRequestMethods.Ftp.Rename;
                reqFTP.RenameTo = newFilename;
                reqFTP.UseBinary = true;
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();

                ftpStream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void makeEventButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFilDlg = new OpenFileDialog();
            if (opFilDlg.ShowDialog() == DialogResult.OK)
            {
                Upload(opFilDlg.FileName);
            }
     
            string MyConString = "SERVER=localhost;" + "DATABASE=onlineclasses;" + "UID=root;" + "PASSWORD=root;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            
            command.CommandText = "insert into eventdatarecord (emailId,insName,topic,date,time) values('" + idTextBox.Text + "','" + insTextBox.Text + "','" + topicTextBox.Text + "','" + dateTextBox.Text + "','" + timeTextBox.Text + "');";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
            }
            
            connection.Close();
            TextBox fs = new TextBox();
            fs.Text = opFilDlg.FileName;//filename
            int len = fs.Text.Length;
            int countSlash = 0,j = -1, k = -1;
            char[] tb = fs.Text.ToArray();
            int[] lm = new int[32767];
            int[] lmk = new int[32767];
            for (int i = 0; i < len; i++)
            {
                if (tb[i].Equals('\\'))
                {
                    countSlash++;
                    j++;
                    lm[j] = i + 1;
                }
            }
            char[] d= new char[len];
            for (int o = lm[j]; o <len; o++)
            {
                d[o] = tb[o];
            }
            string ds = new String(d);
            TextBox ft = new TextBox();
            ft.Text =ds;
 
            Rename(ft.Text,topicTextBox.Text+".mp4");
            contentClear();
            s();
            styletext();
        }

        private void eventDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateTextBox.Text = eventDateTimePicker.Value.ToShortDateString();
        }

        private void dateTextBox_TextChanged(object sender, EventArgs e)
        {
            dateTextBox.Text = eventDateTimePicker.Value.ToShortDateString();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            contentClear();
            styletext();
            s();
        }

        private void eventFormNewEvent_Load(object sender, EventArgs e)
        {
            ftpServerIP = "169.254.206.0";
        }      
    }
}
