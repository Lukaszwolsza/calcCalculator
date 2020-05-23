using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace calcCounter
{
    public partial class loginBox : Form
    {
        public loginBox()
        {
            InitializeComponent();
        }


        public static string userLogin;

        public static string userLoginDisplay
        {
            get { return userLogin; }
            set { userLogin = value; }
        }

        public delegate string getUserLoginD();
        public delegate string getUserPasswordD();

        public string getUserLogin()
        {
            return loginInput.Text;
        }
        public string getUserPassword()
        {
            return passwordInput.Text;
        }

        
        public void changedFinalStatus()
        {
            infoLogginBoxLabel.Text = "Logging.... !";
            Thread.Sleep(5);
        }

        public void loadingBar()
        {
            for (int i = 0; i < 150; i++)
            {
                loggingBarProgress.Value++;
                Thread.Sleep(1);
            }
        }

        public async Task<int> InstallAsync(int value)
        {
            int timeReturned = 0;
            return await Task.Factory.StartNew(() => {
                for (int i = 0; i < value; i++)
                {
                    timeReturned++;
                    Thread.Sleep(30);
                }
                return timeReturned;
            });
        }

        private async void applyLoginButton_Click(object sender, EventArgs e)
        {
            getUserLoginD getuserlog = getUserLogin;
            getUserPasswordD getuserpass = getUserPassword;
            userLoginDisplay = getUserLogin();

            string loginInfo = getuserlog();
            string passwordInfo = getuserpass();

            bool isLogged = false;

            //BASE CONNECT
            connectToBaseUser cntToUserBase = new connectToBaseUser();
            isLogged = cntToUserBase.userAuthenticationInBase(loginInfo, passwordInfo);
            
            if (isLogged)
            {
                mainBox mainMenuBox = new mainBox();
                loggingBarProgress.Visible = true;
                infoLogginBoxLabel.Visible = true;

                loadingBar();

                Task<int> messageTask = InstallAsync(30);

                changedFinalStatus();

                int totalTime = await messageTask;

                Thread.Sleep(totalTime);
                MessageBox.Show("You're logged " + loginInfo);

                mainMenuBox.Show();
                this.Hide();  
            }
            else
            {
                MessageBox.Show("Incorrect password !");
                isLogged = false;
            }

            // OLD USERSERVICE
            //userService userserv = new userService();
            //isLogged = userserv.userAuthentication(loginInfo, passwordInfo);
        }


        

        //private Task<int> InstallAsync(int v)
        //{
        //    throw new NotImplementedException();
        //}

        //public void updateProgress()
        //{
        //    loggingBarProgress.Visible = true;
        //    infoLogginBoxLabel.Visible = true;

        //    Task<int> task = InstallAsync(200);

        //    changedWaitingStatus();
        //    changedFinalStatus();

           

        //    infoLogginBoxLabel.Text = string.Format("End", total);

        //}




        private void registryNewUserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            registrationBox registerBox = new registrationBox();
            registerBox.Show();
        }

        private void loginBoxExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usersInBaseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            registrationBox registerBox = new registrationBox();
            registerBox.Show();
        }

        private void exitRedButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yellowMinimalizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        Point lastPoint;
        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
