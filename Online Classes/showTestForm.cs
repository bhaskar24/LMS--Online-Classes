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
    public partial class showTestForm : Form
    {
        string ss = "";
        public showTestForm()
        {
            _showTestForm = this;
            InitializeComponent();
            s();
        }
        public static showTestForm _showTestForm;

        public string testName()
        {
            return ss;
        }

        public void s()
        {
            listBox.Controls.Clear();
            int x = 40, y = 30;
            string MyConString = "SERVER=localhost;" + "DATABASE=studenttest;" + "UID=root;" + "PASSWORD=root;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;

            command.CommandText = "show tables;";
            connection.Open();
            try
            {
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    LinkLabel lbl = new LinkLabel();
                    lbl.Text = Reader["Tables_in_studenttest"].ToString().ToUpper();
                    lbl.Name = lbl.Text + "LinkLabel";
                    lbl.Click += new EventHandler(lbl_LinkClick);
                    lbl.AutoSize = true;
                    lbl.Location = new Point(x, y);
                    listBox.Items.Add(lbl);
                    listBox.Controls.Add(lbl);
                    lbl.BringToFront();
                    x = x + 316;

                    if (x > 1125)
                    {
                        x = 40;
                        y = y + 40;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No Test Currently Present","Information");
            }
            connection.Close(); 
            
        }
        public void lbl_LinkClick(object sender, EventArgs e)
        {
           string s = sender.ToString();
           char[] d;
           
           d = s.ToCharArray();
           
           for (int i = 38; i < d.Length; i++)
           {
                ss=ss+d[i];
           }
           homeForm._homeForm.mainPanel.Controls.Clear();
           testRegisForm ob = new testRegisForm();
           homeForm._homeForm.mainPanelFunction(ob);
        }
        
        private void showTestForm_Load(object sender, EventArgs e)
        {
            listBox.Controls.Clear();
            s();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s();
        }
    }
}
