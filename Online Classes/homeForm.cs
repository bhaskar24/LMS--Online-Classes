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
    public partial  class homeForm : Form 
    {
      
        public homeForm()
        {
            InitializeComponent();
            _homeForm = this;
            loginIndicator.ForeColor = Color.Gray;
            dateTimeLabel.ForeColor = Color.Gray;
            welcomeLabel.ForeColor = Color.Gray;
            dateTimeLabel.Text = "Session Start Time-" + DateTime.Now.ToString();
            mailTextBox.Visible = false;
        }

        
        public static homeForm _homeForm;

        public void update(string message)
        {
            loginIndicator.Text = message;
            statusLinkLabel.Text = "Sign Out";
        }

        public string nameLabel()
        {
           return loginIndicator.Text;
        }

        public void logInMailId(string a)
        {
            mailTextBox.Text = a;
        }

        public string mailID()
        {
            return mailTextBox.Text;
        }
        public void mainPanelFunction(Form ob)
        {
            mainPanel.Controls.Clear();
            ob.TopLevel = false;
            ob.AutoScroll = true;
            mainPanel.Controls.Add(ob);
            ob.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ob.Show();

        }

     
        
        public string status()
        {
            return statusLinkLabel.Text;
        }

        private void aboutUsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            aboutUsLinkLabel.Enabled = false;
            dashBoardLinkLabel.Enabled = true;
            EBookLinkLabel.Enabled = true;
            onlineTestLinkLabel.Enabled = true;
            newsLinkLabel.Enabled = true;
            queriesLinkLabel.Enabled = true;
            complainsLinkLabel.Enabled = true;

            AboutUsForm obj = new AboutUsForm();
            mainPanelFunction(obj);
               
        }
     
        private void dashBoardLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            aboutUsLinkLabel.Enabled = true;
            dashBoardLinkLabel.Enabled = false;
            EBookLinkLabel.Enabled = true;
            onlineTestLinkLabel.Enabled = true;
            newsLinkLabel.Enabled = true;
            queriesLinkLabel.Enabled = true;
            complainsLinkLabel.Enabled = true;


            dashBoardForm ob = new dashBoardForm();
            mainPanelFunction(ob);
        }

        private void queriesLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            aboutUsLinkLabel.Enabled = true;
            dashBoardLinkLabel.Enabled = true;
            EBookLinkLabel.Enabled = true;
            onlineTestLinkLabel.Enabled = true;
            newsLinkLabel.Enabled = true;
            queriesLinkLabel.Enabled = false;
            complainsLinkLabel.Enabled = true;

            queriesForm ob = new queriesForm();
            mainPanelFunction(ob);
      
        }

        private void complainsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            aboutUsLinkLabel.Enabled = true;
            dashBoardLinkLabel.Enabled = true;
            EBookLinkLabel.Enabled = true;
            onlineTestLinkLabel.Enabled = true;
            newsLinkLabel.Enabled = true;
            queriesLinkLabel.Enabled = true;
            complainsLinkLabel.Enabled = false;

            ComplainsForm ob = new ComplainsForm();
            mainPanelFunction(ob);
      
        }

      
        private void homeForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
          if (loginIndicator.Text.Equals("Guest,"))
            {
                signUpForm ob = new signUpForm();
                mainPanelFunction(ob);
            }

        }

        private void statusLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            if (statusLinkLabel.Text.Equals("Sign Out"))
            {
                statusLinkLabel.Text = "Sign In";
                loginIndicator.Text = "Guest";

                signUpForm ob = new signUpForm();
                mainPanelFunction(ob);
            }
            else
            {
                
                LogInForm ob = new LogInForm();
                mainPanelFunction(ob);
            }
        }

        private void homeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            aboutUsLinkLabel.Enabled = true;
            dashBoardLinkLabel.Enabled = true;
            EBookLinkLabel.Enabled = true;
            onlineTestLinkLabel.Enabled = true;
            newsLinkLabel.Enabled = true;
            queriesLinkLabel.Enabled = true;
            complainsLinkLabel.Enabled = true;

            if (statusLinkLabel.Text.Equals("Sign Out"))
            {
                myAccount ob = new myAccount();
                mainPanelFunction(ob);
            }
            else
            {
                signUpForm ob = new signUpForm();
                mainPanelFunction(ob);
            }
        }

        private void newsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            aboutUsLinkLabel.Enabled = true;
            dashBoardLinkLabel.Enabled = true;
            EBookLinkLabel.Enabled = true;
            onlineTestLinkLabel.Enabled = true;
            newsLinkLabel.Enabled = false;
            queriesLinkLabel.Enabled = true;
            complainsLinkLabel.Enabled = true;

            newsForm os = new newsForm();
            mainPanelFunction(os);
        }

        private void onlineTestLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            aboutUsLinkLabel.Enabled = true;
            dashBoardLinkLabel.Enabled = true;
            EBookLinkLabel.Enabled = true;
            onlineTestLinkLabel.Enabled = false;
            newsLinkLabel.Enabled = true;
            queriesLinkLabel.Enabled = true;
            complainsLinkLabel.Enabled = true;

            showTestForm ob = new showTestForm();
            mainPanelFunction(ob);
        }

        private void EBooklinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            aboutUsLinkLabel.Enabled = true;
            dashBoardLinkLabel.Enabled = true;
            EBookLinkLabel.Enabled = false;
            onlineTestLinkLabel.Enabled = true;
            newsLinkLabel.Enabled = true;
            queriesLinkLabel.Enabled = true;
            complainsLinkLabel.Enabled = true;
            EBookForm ob = new EBookForm();
            mainPanelFunction(ob);
        }   
    }
}
