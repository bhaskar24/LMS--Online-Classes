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
    public partial class myAccount : Form
    {
        string ftpServerIP = "169.254.206.0";
      
        TextBox tempTextBox = new TextBox();
        public myAccount()
        {
            InitializeComponent();
            _uid = this;
            tempTextBox.Visible = false;
        }
        public static myAccount  _uid;
        
        public string uidReturnFun()
        {
            return fnameLabel.Text + cntctNumberLabel.Text;
        }

        public string uidEmailId()
        {
            return emailIdLabel.Text;
        }

        public void  studStatus(string s)
        {
            if ((s.Equals("[Select]")) || (s.Equals("Individual Teacher or Trainer")) || (s.Equals("Organization With Multiple Teacher")))
            {
                studRadioButton.Visible = true;
            }
            else
            {
                studRadioButton.Visible = false;
            }
            
        }
        private void myAccount_Load(object sender, EventArgs e)
        {
            tempTextBox.Text = homeForm._homeForm.mailID();
            
            string MyConStringAcnt = "SERVER=localhost;" + "DATABASE=onlineclasses;" + "UID=root;" + "PASSWORD=root;";
            MySqlConnection connectionAcnt = new MySqlConnection(MyConStringAcnt);
            MySqlCommand commandAcnt = connectionAcnt.CreateCommand();
            MySqlDataReader ReaderAcnt;
            commandAcnt.CommandText = "SELECT * from  userdatarecord where emailId='"+tempTextBox.Text+"';";
            connectionAcnt.Open();
            ReaderAcnt = commandAcnt.ExecuteReader();
            while (ReaderAcnt.Read())
            {
                fnameLabel.Text = ReaderAcnt["fname"].ToString();
                lnameLabel.Text = ReaderAcnt["lname"].ToString();
                emailIdLabel.Text = ReaderAcnt["emailId"].ToString();
                paswdLabel.Text = ReaderAcnt["paswd"].ToString();
                countryLabel.Text = ReaderAcnt["country"].ToString();
                cntctNumberLabel.Text = ReaderAcnt["cntctNumber"].ToString();
                acntTypeLabel.Text = ReaderAcnt["acntType"].ToString();
                idlabel.Text = fnameLabel.Text + cntctNumberLabel.Text;
                
            }
            connectionAcnt.Close();

            if (acntTypeLabel.Text.Equals("Learner Or Student"))
            {
                createTestRadioButton.Visible = false;
                newEventRadioButton.Visible = false;
                studRadioButton.Visible = false;
                pNewsRadioButton.Visible = false;
                testReportRadioButton.Location = new Point(118,412);
                moreButton.Visible = false;
                ebLabel.Visible = false;
            }
          }

        private void editAcntRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            
            myAcntEditDetailsFormcs ob = new myAcntEditDetailsFormcs();
            ob.TopLevel = false;
            ob.AutoScroll = true;
            mainPanel.Controls.Add(ob);
            ob.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ob.Show();

        }

        private void mngEventRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            manageEventsForm ob = new manageEventsForm();
            mainPanel.Controls.Clear();
            ob.TopLevel = false;
            ob.AutoScroll = true;
            mainPanel.Controls.Add(ob);
            ob.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ob.Show();
            
        }

        private void registeredEventsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            eventVideoForm ob = new eventVideoForm();
            homeForm._homeForm.mainPanelFunction(ob);
        }

        private void newEventRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            
            eventFormNewEvent ob = new eventFormNewEvent();
            ob.TopLevel = false;
            ob.AutoScroll = true;
            mainPanel.Controls.Add(ob);
            ob.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ob.Show();
        }

        private void regForEventRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            eventFormRegister ob = new eventFormRegister();
            
            mainPanel.Controls.Clear();
            ob.TopLevel = false;
            ob.AutoScroll = true;
            mainPanel.Controls.Add(ob);
            ob.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ob.Show();
     
        }

        private void studRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            studProbForm ob = new studProbForm();
            
            mainPanel.Controls.Clear();
            ob.TopLevel = false;
            ob.AutoScroll = true;
            mainPanel.Controls.Add(ob);
            ob.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ob.Show();



        }

        private void createTestRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            myTestForm ob = new myTestForm();
            mainPanel.Controls.Clear();
            ob.TopLevel = false;
            ob.AutoScroll = true;
            mainPanel.Controls.Add(ob);
            ob.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ob.Show();

        }

        private void testReportRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ReportForm ob = new ReportForm();
            mainPanel.Controls.Clear();
            ob.TopLevel = false;
            ob.AutoScroll = true;
            mainPanel.Controls.Add(ob);
            ob.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ob.Show();

        }

        private void pNewsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pNewsForm ob = new pNewsForm();
            mainPanel.Controls.Clear();
            ob.TopLevel = false;
            ob.AutoScroll = true;
            mainPanel.Controls.Add(ob);
            ob.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ob.Show();
 
        }
        public void Upload(string uploadDb)
        {
            FileInfo fileInf = new FileInfo(uploadDb);
            string uri = "ftp://" + ftpServerIP + "/EBooks/" + fileInf.Name;
            FtpWebRequest reqFTP;

            reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP) + "/EBooks/" + fileInf.Name);
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
                MessageBox.Show("Upload Error","PDF File Upload Error");
            }

        }
       
        private void moreButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFilDlg = new OpenFileDialog();
            opFilDlg.Filter = "pdf files (*.pdf) |*.pdf;";
             
            if (opFilDlg.ShowDialog() == DialogResult.OK)
            {
                Upload(opFilDlg.FileName);
            }
     
        }  
    }
}
