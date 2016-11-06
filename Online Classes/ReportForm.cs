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
    public partial class ReportForm : Form
    {
        int x, y;
        public ReportForm()
        {
            InitializeComponent();
        }

       
        private void ReportForm_Load(object sender, EventArgs e)
        {
            string h =homeForm._homeForm.status();
            testRecordListView.GridLines = false;
            string MyConString = "SERVER=localhost;" + "DATABASE=studenttestrecord;" + "UID=root;" + "PASSWORD=root;";
        
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            
            string s;
            if (h.Equals("Sign Out"))
            {
                testRecordListView.Location = new Point(12,44);
                s = myAccount._uid.uidReturnFun();
            }
            else
            {
                s = testRegisForm._testRegisForm.uID();
            }
            command.CommandText = "select * from " + s + ";";
            
            connection.Open();
            try
            {
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    testRecordListView.Items.Add(new ListViewItem(new[] { Reader["sr"].ToString(), Reader["testName"].ToString(), Reader["duration"].ToString(), Reader["date"].ToString(), Reader["maxMarks"].ToString(), Reader["obtainMarks"].ToString(), Reader["status"].ToString() }));
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Not Test Record Available","Information");
            }
            connection.Close();
        
        }
    }
}
