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
    public partial class ComplainsForm : Form
    {
        public ComplainsForm()
        {
            InitializeComponent();
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            TextBox t = new TextBox();
            DateTime dt = new DateTime();
            t.Text = dt.ToShortDateString();
            string MyConStringAcnt = "SERVER=localhost;" + "DATABASE=onlineclasses;" + "UID=root;" + "PASSWORD=root;";
            MySqlConnection connectionAcnt = new MySqlConnection(MyConStringAcnt);
            MySqlCommand commandAcnt = connectionAcnt.CreateCommand();
            MySqlDataReader ReaderAcnt;

            commandAcnt.CommandText = "insert into complains(complain,date)values('"+compRichTextBox.Text+"','"+t.Text+"');";
            connectionAcnt.Open();
            ReaderAcnt = commandAcnt.ExecuteReader();
            while (ReaderAcnt.Read())
            {
            }
            connectionAcnt.Close();
            MessageBox.Show("Submitted!!");
        }

    
     }
}
