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
    public partial class onlineTestForm : Form
    {
        TextBox tn = new TextBox();
         
        int ise = 00, jmi = 00, lhr = 00;//sec min hr
        int fl, fj;
        string corrAns, eID, duration, date, tQue,testName;
        int corrAnsCounter = 0,wrongAnsCounter=0,queCounter=1,totalQue;
       
        public onlineTestForm()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 999;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
       
        }
        public void ti()
        {
            string ff = "";
            char[] d = new char[5];
            string f1 = "", f2 = "";
            string MyConString = "SERVER=localhost;" + "DATABASE=studenttest;" + "UID=root;" + "PASSWORD=root;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;

            command.CommandText = "select * from " + testName + " where sr=1;";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                ff = Reader["duration"].ToString();
            }
            connection.Close();
            d = ff.ToArray();
            
            f1 = d[0].ToString() + d[1].ToString();
            f2 = d[3].ToString() + d[4].ToString();
            
            fl = int.Parse(f1);
            fj = int.Parse(f2);
            
      
        }
        private static readonly Random getrandom = new Random();
        private static readonly object syncLock = new object();
        public static int GetRandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return getrandom.Next(min, max);
            }
        }
        public void testDetailsLoad()
        {
            string testName = showTestForm._showTestForm.testName();
            string MyConString = "SERVER=localhost;" + "DATABASE=studenttest;" + "UID=root;" + "PASSWORD=root;";
            
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;

            command.CommandText = "select * from "+testName+" where sr=1;";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
               eID=Reader["emailId"].ToString();//eID
               tQue=Reader["noOfQues"].ToString();//totalQue
               duration=Reader["duration"].ToString();//duration
               date =Reader["onDate"].ToString();//date
            }
            connection.Close(); 
            totalQue=int.Parse(tQue);//totalque
        }

        public void queLoad()
        {
            testName = showTestForm._showTestForm.testName();
            string MyConString = "SERVER=localhost;" + "DATABASE=studenttest;" + "UID=root;" + "PASSWORD=root;";
            int randq = GetRandomNumber(1,totalQue+1);//randQue.Next(1, totalQue+1);
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;

            command.CommandText = "select * from " + testName + " where sr='"+randq+"';";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                queRichTextBox.Text=Reader["question"].ToString();
                opt1RadioButton.Text = Reader["opt1"].ToString();
                opt2RadioButton.Text = Reader["opt2"].ToString();
                opt3RadioButton.Text = Reader["opt3"].ToString();
                opt4RadioButton.Text = Reader["opt4"].ToString();
                corrAns = Reader["correctOpt"].ToString();
            }
            connection.Close();
            nQueLabel.Text = totalQue.ToString();//noofque
            queCounterLabel.Text = queCounter.ToString();//attemptQue

           // hrLabel.Text = fl.ToString();
            //min.Text = fj.ToString();
        }

        public void correctAnsCheck()
        {
            if (opt1RadioButton.Checked.Equals(true))
            {
                if (opt1RadioButton.Text.Equals(corrAns))
                {
                    corrAnsCounter++;
                }
                else
                {
                    wrongAnsCounter++;
                }

            }
            if (opt2RadioButton.Checked.Equals(true))
            {
                if (opt2RadioButton.Text.Equals(corrAns))
                {
                    corrAnsCounter++;
                }
                else
                {
                    wrongAnsCounter++;
                }

            }
            if (opt3RadioButton.Checked.Equals(true))
            {
                if (opt3RadioButton.Text.Equals(corrAns))
                {
                    corrAnsCounter++;
                }
                else
                {
                    wrongAnsCounter++;
                }

            }
            if (opt4RadioButton.Checked.Equals(true))
            {
                if (opt4RadioButton.Text.Equals(corrAns))
                {
                    corrAnsCounter++;
                }
                else
                {
                    wrongAnsCounter++;
                }

            }
            if (opt1RadioButton.Checked == false && opt2RadioButton.Checked == false && opt3RadioButton.Checked == false && opt4RadioButton.Checked == false)
            {
                wrongAnsCounter++;
            }
       }

        private void onlineTestForm_Load(object sender, EventArgs e)
        {
            testDetailsLoad();
            queLoad();
            ti();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            ise = ise + 01;
            {
                if (ise > 60)
                {
                    ise = 0;
                    secLabel.Text = "0" + ise;
                    jmi++;
                }
                else
                {
                    if (ise < 10)
                    {
                        secLabel.Text = "0" + ise;
                    }
                    else
                    {
                        secLabel.Text = "" + ise;
                    }
                }
                if (jmi >= 60)
                {
                    jmi = 0;
                    min.Text = "0" + jmi;
                    lhr++;
                }
                else
                {
                    if (jmi < 10)
                    {
                        min.Text = "0" + jmi;
                    }
                    else
                    {
                        min.Text = "" + jmi;
                    }

                }
                if (lhr >= 24)
                {
                    lhr = 0;
                    hr.Text = "0" + lhr;
                    lhr++;
                }
                else
                {
                    if (lhr < 10)
                    {
                        hr.Text = "0" + lhr;
                    }
                    else
                    {
                        hr.Text = "" + lhr;
                    }
                }
     
            }
        }

        private void onlineTestForm_Deactivate(object sender, EventArgs e)
        {
            finalTestReport();
            this.Dispose();
            ReportForm ob = new ReportForm();
            homeForm._homeForm.mainPanelFunction(ob);
            
        }

        public void finalTestReport()
        {
            string MyConString = "SERVER=localhost;" + "DATABASE=studenttestrecord;" + "UID=root;" + "PASSWORD=root;";
            string status;
            double o = (corrAnsCounter / totalQue) * 100;
            if (o > 80)
            {
                status = "A";
            }
            else if (o > 60 && o < 80)
            {
                status = "B";
            }
            else if (o < 60 && o > 40)
            {
                status = "C";
            }
            else
            {
                status = "Fail";
            }
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;

            string x = testRegisForm._testRegisForm.uID(); 
            tn.Text = testName;
            TextBox d = new TextBox();
            d.Text = duration;
            TextBox da = new TextBox();
      
            DateTime dt = DateTime.Now;
            int hours1 = dt.Hour;
            int minutes1 = dt.Minute;
            int seconds1 = dt.Second;
            da.Text =date+"  "+ hours1.ToString() + ":" + minutes1.ToString() + ":" + seconds1.ToString(); 
          
            TextBox tq = new TextBox();
            tq.Text = totalQue.ToString();
            TextBox ca = new TextBox();
            ca.Text = corrAnsCounter.ToString();
            TextBox s = new TextBox();
            s.Text = status;
            command.CommandText = "INSERT INTO " + x + "(testName,duration,date,maxMarks,obtainMarks,status)VALUES('"+tn.Text+"','"+d.Text+"','"+da.Text+"','"+tq.Text+"','"+ca.Text+"','"+s.Text+"');";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
            }
            connection.Close();

        }
        private void subButton_Click(object sender, EventArgs e)
        {
            if (queCounter <= totalQue)
            {
                queCounter++;
                correctAnsCheck();
            }
           if (queCounter <= totalQue)
           {
                queLoad();
                opt1RadioButton.Checked = false;
                opt2RadioButton.Checked = false;
                opt3RadioButton.Checked = false;
                opt4RadioButton.Checked = false;
            }
            else
            {
                finalTestReport();
                ReportForm ob = new ReportForm();
                homeForm._homeForm.mainPanelFunction(ob);
            }
        }

        private void min_TextChanged(object sender, EventArgs e)
        {
        
            if (fj == jmi && fl == lhr)
            {
                timer1.Stop();
                finalTestReport();
                this.Dispose();
            
                ReportForm ob = new ReportForm();
                homeForm._homeForm.mainPanelFunction(ob);
            
            }

        }
    }
}
