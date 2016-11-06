using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Online_Classes
{
    public partial class EBookForm : Form
    {
        string ftpServerIP = "169.254.206.0";
        public EBookForm()
        {
            InitializeComponent();
        }

        public void Upload(string uploadDb)
        {
            FileInfo fileInf = new FileInfo(uploadDb);
            string uri = "ftp://" + ftpServerIP + "/" + fileInf.Name;
            FtpWebRequest reqFTP;

            reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP) + "/Ebooks" + fileInf.Name);
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
        public string[] GetFilesDetailList()
        {
            string[] downloadFiles;
            try
            {
                StringBuilder result = new StringBuilder();
                FtpWebRequest ftp;
                ftp = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/Ebooks"));
                ftp.Method = WebRequestMethods.Ftp.ListDirectory;//here i make change with ListDirectoryDetails
                WebResponse response = ftp.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string line = reader.ReadLine();
                while (line != null)
                {
                    result.Append(line);
                    result.Append("\n");
                    line = reader.ReadLine();
                }
                result.Remove(result.ToString().LastIndexOf("\n"), 1);
                reader.Close();
                response.Close();
                return result.ToString().Split('\n');
            }
            catch (Exception ex)
            {
                showBbutton.Enabled = false;
                MessageBox.Show("No Files","Information");
                downloadFiles = null;
                string[] s=new string[1];
                return downloadFiles=s;
            }
        }
        private void Download(string filePath, string fileName)
        {
            FtpWebRequest reqFTP;
            try
            {
                //filePath = <<The full path where the file is to be created.>>, 
                //fileName = <<Name of the file to be created(Need not be the name of the file on FTP server).>>
                FileStream outputStream = new FileStream(filePath + "\\" + fileName, FileMode.Create);

                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "//EBooks//" + fileName));
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
            }
        }
        
        private void EBookForm_Load(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists("C:\\Video\\EBooks\\"))//d filename
            {
                System.IO.Directory.CreateDirectory("C:\\Video\\EBooks\\");
            }
          
            videosListView.GridLines = false;
            string[] filenames = GetFilesDetailList();
            videosListView.Items.Clear();
            foreach (string filename in filenames)
            {
                videosListView.Items.Add(filename);
            }

        }

        private void showBbutton_Click(object sender, EventArgs e)
        {
            TextBox sc = new TextBox();
            sc.Text = videosListView.SelectedItems[0].SubItems[0].Text;
            Download("C:\\Video\\EBooks\\", sc.Text);

            System.IO.Directory.CreateDirectory("C:\\Video\\EBooks\\");
            if (!System.IO.Directory.Exists("Video"))
            {
                System.IO.Directory.CreateDirectory("C:\\Video\\EBooks\\");
            }
            //d.Attributes = FileAttributes.Hidden;

            if (sc.Text.Trim().Length > 0)
            {
                Download("c:\\Video\\EBooks\\", sc.Text.Trim());

                string pdfFileName = "c:\\Video\\EBooks\\"+sc.Text+"";
                System.Diagnostics.Process.Start(pdfFileName);

            }
            else
            {
                MessageBox.Show("Your Memory is Full");
            }
       
        }
    }
}
