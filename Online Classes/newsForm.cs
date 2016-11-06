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
    public partial class newsForm : Form
    {
        int s = 1,k;
        public newsForm()
        {
            InitializeComponent();
        }
        public int  sdwr()
        {
            string MyConString = "SERVER=localhost;" + "DATABASE=news;" + "UID=root;" + "PASSWORD=root;";
            int d = 0;
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select sr,image,news,head from studentnews;";
            connection.Open();

            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                d = int.Parse(Reader["sr"].ToString());
            }
            connection.Close();
            return d;

        }
       
        public void sd()
        {
            string MyConString = "SERVER=localhost;" + "DATABASE=news;" + "UID=root;" + "PASSWORD=root;";

            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select sr,image,news,head from studentnews where sr=" + s + ";";
            connection.Open();

            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                byte[] imgg = (byte[])(Reader["image"]);
                if (imgg == null)
                {
                    newsPictureBox.Image = null;
                }
                else
                {
                    MemoryStream mstream = new MemoryStream(imgg);
                    newsPictureBox.Image = System.Drawing.Image.FromStream(mstream);
                }
                newsRichTextBox.Text = Reader["news"].ToString();
                nhRichTextBox.Text=Reader["head"].ToString();
            }
            connection.Close();
            k = sdwr();
        }
        private void newsForm_Load(object sender, EventArgs e)
        {
            sd();
        }

        private void moreButton_Click(object sender, EventArgs e)
        {
            s++;
            if (s <= k)
            {
                sd();
            }
            {
                sd();
            }

        }
    }
}
