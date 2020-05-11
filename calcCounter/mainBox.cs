using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcCounter
{
    public partial class mainBox : Form
    {
        public mainBox()
        {
            InitializeComponent();
            
            //userNickTextLabel.Text = userLogin;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void accountInfoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            accountInfo accInfo = new accountInfo();
            accInfo.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginBox loginBoxReturn = new loginBox();
            loginBoxReturn.Show();
        }

        private void mainBox_Load(object sender, EventArgs e)
        {
            userService newservice = new userService();
            loginBox loginbox = new loginBox();

            string login = loginBox.userLoginDisplay;
            accountInfo accountinfo = new accountInfo();
            //          double userBMR = accountinfo.getUserBMR(newservice.userAge(login), newservice.userWeight(login), newservice.userHeight(login));

            double userBMR = accountinfo.getBMR();

            //userNickTextLabel.Text = newservice.userGreetingAndName(login) + " ! :)";
           // maxKcalLabel.Text = userBMR.ToString();

            //          string monthName = DateTime.Now.ToString("MMM", CultureInfo.InvariantCulture);

            //         dateLabel.Text += DateTime.Now.ToString(monthName);

            DateTime currentDay = DateTime.Today;
            dateLabel.Text += " " + currentDay.ToString("d");

            //double maxP = Math.Round((0.35 * userBMR) / 4 , 0);
            //double maxT = Math.Round((0.25 * userBMR) / 9 , 0);
            //double maxC = Math.Round((0.4 * userBMR) / 4 , 0);
            

            //maxProtein.Text = maxP.ToString() + " g";
            //maxFat.Text = maxT.ToString() + " g";
            //maxCarbs.Text = maxC.ToString() + " g";


            // MEALS conf //

            //string breakfast = breakfastLabel.Text;
            //string IIbreakfast = IIbreakbastLabel.Text;
            //string dinner = dinnerLabel.Text;
            //string snack = snackLabel.Text;
            //string supper = supperLabel.Text;

            breakfastLabel.Text = "Nothing";
            IIbreakbastLabel.Text = "Nothing";
            dinnerLabel.Text = "Nothing";
            snackLabel.Text = "Nothing";
            supperLabel.Text = "Nothing";
        }

        private void yellowMinimalizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitRedButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void copyrightsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            copyrightsBox copyrights = new copyrightsBox();
            copyrights.Show();
        }

        private void productInBaseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            productBox prod = new productBox();
            prod.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addProductToMeal newprodtomeal = new addProductToMeal();
            newprodtomeal.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addProductToMeal newprodtomeal = new addProductToMeal();
            newprodtomeal.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            addProductToMeal newprodtomeal = new addProductToMeal();
            newprodtomeal.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addProductToMeal newprodtomeal = new addProductToMeal();
            newprodtomeal.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addProductToMeal newprodtomeal = new addProductToMeal();
            newprodtomeal.Show();
        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
