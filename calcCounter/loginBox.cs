using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcCounter
{
    public partial class loginBox : Form
    {
        public loginBox()
        {
            InitializeComponent();
            //userService usrservice = new userService();
            //usrservice.defaultAdmin();
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
        private void applyLoginButton_Click(object sender, EventArgs e)
        {
            getUserLoginD getuserlog = getUserLogin;
            getUserPasswordD getuserpass = getUserPassword;

            userService userserv = new userService();
            userLoginDisplay = getUserLogin();


            string loginInfo = getuserlog();
            string passwordInfo = getuserpass();

            bool isLogged;

            isLogged = userserv.userAuthentication(loginInfo, passwordInfo);

            //BASE CONNECT
            //connectToBaseUser cntToUserBase = new connectToBaseUser();
            //isLogged = cntToUserBase.userAuthenticationInBase(loginInfo, passwordInfo);


            if (isLogged)
            {
                this.Close();
            }          
        }
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
    }
}
