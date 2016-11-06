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
    public partial class pNewsForm : Form
    {
        TextBox textBox_image_path = new TextBox();
        public pNewsForm()
        {
            InitializeComponent();
        }

   
        private void newsPictureBox_Click(object sender, EventArgs e)
        {
            newsPictureBox.Controls.Clear();
            fdOpenFileDialog.Filter = "Image(*.png)|*.png|ALL FILES(*.*)|*.*";
            if (fdOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string picpath = fdOpenFileDialog.FileName.ToString();
                textBox_image_path.Text = picpath;
                newsPictureBox.ImageLocation = picpath;
            }
            label2.Visible = false;
        }

 
        private void submitButton_Click(object sender, EventArgs e)
        {
            byte[] imageBt = null;
            FileStream fstream = new FileStream(this.textBox_image_path.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBt = br.ReadBytes((int)fstream.Length);

            newsPictureBox.Image = System.Drawing.Image.FromStream(fstream);

            string MyConString = "SERVER=localhost;" + "DATABASE=news;" + "UID=root;" + "PASSWORD=root;";

            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;

            command.CommandText = "insert into  studentnews(image,news,head)values(@img,@nw,@hd);";

            connection.Open();
            command.Parameters.Add(new MySqlParameter("img", imageBt));
            command.Parameters.Add(new MySqlParameter("nw", newsRichTextBox.Text));
            command.Parameters.Add(new MySqlParameter("hd", newsHTextBox.Text));
         
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {

            }
            connection.Close();
            newsPictureBox.Image = null;
            newsRichTextBox.Clear();
            newsHTextBox.Clear();
            newsHTextBox.Text = "Enter Headline";
            label1.Enabled = true;
            label2.Enabled = true;
        }

     }
}
