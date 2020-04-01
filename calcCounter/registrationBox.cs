using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcCounter
{
    public partial class registrationBox : Form
    {
        public registrationBox()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userBirthdayLabel_Click(object sender, EventArgs e)
        {

        }

        public string getUserLogin()
        {
            return userLoginInput.Text;
        }

        public string getUserPassword()
        {
            return userPasswordInput.Text;
        }
        private void registerApplyButton_Click(object sender, EventArgs e)
        {
            //users user = new users();

            string userLogin = getUserLogin();
            string userPassword = getUserPassword();
            string userName = userNameInput.Text;
            string userLastName = userLastNameInput.Text;
            int userAge = Convert.ToInt32(userAgeInput.Text);
            string userEmail = userEmailInput.Text;
            int userWeight = Convert.ToInt32(userWeightInput.Text);
            int userHeight = Convert.ToInt32(userHeightInput.Text);

            if(userLogin == "" && userPassword == "" && userName == "" && userLastName == "" && userAge < 0 && userEmail == "" && userWeight < 0 && userHeight < 0)
            {
                MessageBox.Show("All fields must be completed ! ");
            }

            userService services = new userService();
            services.addNewUserToList(userLogin, userPassword, userName, userLastName, userAge, userEmail, userHeight, userWeight);

            MessageBox.Show("You've been added " + userLogin + " !");
            
                
            this.Hide();
            loginBox loginBoxReturn = new loginBox();
            loginBoxReturn.Show();
        }

        private void returnToLoginBoxButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginBox loginBoxReturn = new loginBox();
            loginBoxReturn.Show();
        }

        private void userLoginLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void registrationBoxExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void registrationBox_Load(object sender, EventArgs e)
        {

        }

        private void yellowMinimalizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitRedButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
