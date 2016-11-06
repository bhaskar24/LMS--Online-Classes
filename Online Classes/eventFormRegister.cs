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
    public partial class eventFormRegister : Form
    {
        String ftpServerIP = "169.254.206.0";
        string tableName = "";
        //TextBox idTextBox = new TextBox();

        public eventFormRegister()
        {
            InitializeComponent();
            _eventFormRegister = this;
            insTextBox.Visible = false;
            topicTextBox.Visible = false;
            dateTextBox.Visible = false;
            timeTextBox.Visible = false;
            styleCont();  
            s();
        }
        public static eventFormRegister _eventFormRegister;
      
        public void makeidvisible(string n)
        {
            idTextBox.Text = n;
        }

        public void styleCont()
        {
            idTextBox.ForeColor = Color.Gray;
            idTextBox.Text = "Enter Identification Number";
            insTextBox.ForeColor = Color.Gray;
            insTextBox.Text = "Enter Institue/College Name";
            topicTextBox.ForeColor = Color.Gray;
            topicTextBox.Text = "Enter Event Topic";
            dateTextBox.ForeColor = Color.Gray;
            timeTextBox.ForeColor = Color.Gray;
            timeTextBox.Text = DateTime.Now.ToString();
       
        }
        public void contentClear()
        {
            idTextBox.Clear();
            insTextBox.Clear();
            topicTextBox.Clear();
            dateTextBox.Clear();
            timeTextBox.Clear();
        }
        public void s()
        {
          //  if (homeForm._homeForm.status().Equals("Sign Out"))
            //{
                idTextBox.Text = myAccount._uid.uidEmailId();
            //}
            //else 
          //  {
            //    idTextBox.Text = "Enter Identification No.";
            //}
     
            string MyConString = "SERVER=localhost;" + "DATABASE=onlineclasses;" + "UID=root;" + "PASSWORD=root;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;

            command.CommandText = "select * from eventdatarecord  order by date desc;";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                videosListView.Items.Add(new ListViewItem(new[] { Reader["Sr"].ToString(), Reader["insName"].ToString(), Reader["topic"].ToString(), Reader["date"].ToString(), Reader["time"].ToString(), Reader["videoPath"].ToString() }));
            }

            connection.Close();

        }
        private void eventFormRegister_Load(object sender, EventArgs e)
        {
            idTextBox.Text = myAccount._uid.uidEmailId();
            videosListView.Items.Clear();
            s();
        }
        private void Download(string filePath, string fileName)
        {
            FtpWebRequest reqFTP;
            try
            {
                FileStream outputStream = new FileStream(filePath + "\\" + fileName, FileMode.Create);

                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + fileName));
                reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                reqFTP.UseBinary = true;
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();
                long cl = response.ContentLength;
                int bufferSize = 2048;
                int readCount;
                byte[] buffer = new byte[bufferSize];

                readCount = ftpStream.Read(buffer, 0, bufferSize);
                while (readCount > 0)
                {
                    outputStream.Write(buffer, 0, readCount);
                    readCount = ftpStream.Read(buffer, 0, bufferSize);
                }

                ftpStream.Close();
                outputStream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      
        private void regButton_Click(object sender, EventArgs e)
        {
            insTextBox.Text = videosListView.SelectedItems[0].SubItems[1].Text; //ins name
            topicTextBox.Text = videosListView.SelectedItems[0].SubItems[2].Text;//topic
            dateTextBox.Text = videosListView.SelectedItems[0].SubItems[3].Text;//date
            timeTextBox.Text = videosListView.SelectedItems[0].SubItems[4].Text;//time
          
            string d=myAccount._uid.uidReturnFun();
            if (!System.IO.Directory.Exists("C:\\Video\\"+d))
            {
                System.IO.Directory.CreateDirectory("C:\\Video\\"+d);
                System.IO.DirectoryInfo df = new DirectoryInfo("c:\\Video\\");
                df.Attributes = FileAttributes.Hidden;
            }
           //System.IO.DirectoryInfo d = new System.IO.DirectoryInfo("C:\\Video\\");
            //d.Attributes = FileAttributes.Hidden;
           
            Download("C:\\Video\\"+d+"\\",topicTextBox.Text+".mp4");
            string p = "C:\\Video\\"+d+"\\"+topicTextBox.Text+".mp4";
            string t = "";
            for (int i = 0; i < p.Length; i++)
            {
                if (p.ElementAt(i).Equals('\\'))
                {
                    t = t + '\\' + p.ElementAt(i);
                }
                else { t = t + p.ElementAt(i); }
            }
            string MyConStringAcnt = "SERVER=localhost;" + "DATABASE=onlineclasses;" + "UID=root;" + "PASSWORD=root;"; 
            MySqlConnection connectionAcnt = new MySqlConnection(MyConStringAcnt);
            MySqlCommand commandAcnt = connectionAcnt.CreateCommand();
            MySqlDataReader ReaderAcnt;

            commandAcnt.CommandText = "select fname,emailId,cntctNumber from userdatarecord where emailId='" + idTextBox.Text + "';";
            connectionAcnt.Open();
            ReaderAcnt = commandAcnt.ExecuteReader();
            while (ReaderAcnt.Read())
            {
                tableName = ReaderAcnt["fname"].ToString() + ReaderAcnt["cntctNumber"].ToString();
            }
            connectionAcnt.Close();

            string MyConString = "SERVER=localhost;" + "DATABASE=onlineclasses;" + "UID=root;" + "PASSWORD=root;";
            
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            
            command.CommandText = "insert into " + tableName + " (insName,topic,date,time,videoPath) values('" + insTextBox.Text + "','" + topicTextBox.Text + "','" + dateTextBox.Text + "','" + timeTextBox.Text + "','" + t + "');";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
            }
            contentClear();
            videosListView.Items.Clear();
   
            s();
            
            connection.Close();
            
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

        private void timeTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            timeTextBox.Clear();
            timeTextBox.ForeColor = Color.Black;
        }

      
        private void refreshButton_Click(object sender, EventArgs e)
        {
            videosListView.Items.Clear();
            s();
        }
    }
}
