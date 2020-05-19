using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcCounter
{
    public static class ProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar p, int state)
        {
            SendMessage(p.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }


    public partial class mainBox : Form
    {
        public mainBox()
        {
            InitializeComponent();
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
            //userService newservice = new userService();
            connectToBaseUser cntToUserBase = new connectToBaseUser();
            connectToBaseProduct cntToBaseProd = new connectToBaseProduct();
            loginBox loginbox = new loginBox();

            string login = loginBox.userLoginDisplay;

            // <LIST> 
            accountInfo accountinfo = new accountInfo();
            double userBMR = accountinfo.getUserBMR(cntToUserBase.userAge(login), cntToUserBase.userWeight(login), cntToUserBase.userHeight(login));
            double userBMI = accountinfo.getBMI();


            userNickTextLabel.Text = cntToUserBase.userGreetingAndName(login) + " ! :)";
            maxKcalLabel.Text = userBMR.ToString();

            //string monthName = DateTime.Now.ToString("MMM", CultureInfo.InvariantCulture);

            //dateLabel.Text += DateTime.Now.ToString(monthName);

            DateTime currentDay = DateTime.Today;
            dateLabel.Text += " " + currentDay.ToString("d");

            double maxP = Math.Round((0.35 * userBMR) / 4 , 0);
            double maxF = Math.Round((0.25 * userBMR) / 9 , 0);
            double maxC = Math.Round((0.4 * userBMR) / 4 , 0);
            



            maxProtein.Text = maxP.ToString() + " g";
            maxFat.Text = maxF.ToString() + " g";
            maxCarbs.Text = maxC.ToString() + " g";

            int fullcaloriesEaten = cntToBaseProd.gettingFullCalories(login);
            caloriesAte.Text = fullcaloriesEaten.ToString();

            int fullproteinEaten = cntToBaseProd.gettingFullProtein(login);
            proteinsAte.Text = fullproteinEaten.ToString();

            int fullfatsEaten = cntToBaseProd.gettingFullFat(login);
            fatsAte.Text = fullfatsEaten.ToString();

            int fullcarbsEaten = cntToBaseProd.gettingFullCarbs(login);
            carbsAte.Text = fullcarbsEaten.ToString();

            pbCalories.Minimum = 0;
            pbProtein.Minimum = 0;
            pbFat.Minimum = 0;
            pbCarbs.Minimum = 0;

            pbCalories.Maximum = Convert.ToInt32(userBMR);
            pbProtein.Maximum = Convert.ToInt32(maxP);
            pbFat.Maximum = Convert.ToInt32(maxF);
            pbCarbs.Maximum = Convert.ToInt32(maxC);

            pbCalories.Value = Math.Min(fullcaloriesEaten, Convert.ToInt32(userBMR));
            pbProtein.Value = Math.Min(fullproteinEaten, Convert.ToInt32(maxP));
            pbFat.Value = Math.Min(fullfatsEaten, Convert.ToInt32(maxF));
            pbCarbs.Value = Math.Min(fullcarbsEaten, Convert.ToInt32(maxC));


            if (pbCalories.Value >= pbCalories.Maximum)
            {
                ProgressBarColor.SetState(pbCalories, 2);
            }
            if (pbFat.Value >= pbFat.Maximum)
            {
                ProgressBarColor.SetState(pbFat, 2);
            }
            if (pbProtein.Value >= pbProtein.Maximum)
            {
                ProgressBarColor.SetState(pbProtein, 2);
            }
            if(pbCarbs.Value >= pbCarbs.Maximum)
            {
                ProgressBarColor.SetState(pbCarbs, 2);
            }





                // MEALS conf //
                //string breakfast = breakfastLabel.Text;
                //string IIbreakfast = IIbreakbastLabel.Text;
                //string dinner = dinnerLabel.Text;
                //string snack = snackLabel.Text;
                //string supper = supperLabel.Text;

                //breakfastLabel.Text = "Nothing";
                //IIbreakbastLabel.Text = "Nothing";
                //dinnerLabel.Text = "Nothing";
                //snackLabel.Text = "Nothing";
                //supperLabel.Text = "Nothing";

                string[] typeofmeal = new string[] { "Breakfast", "Second Breakfast", "Dinner", "Snack", "Supper" };

            breakfastLabel.Text = cntToBaseProd.prodView(login,typeofmeal[0]) + " , ";
            IIbreakbastLabel.Text = cntToBaseProd.prodView(login, typeofmeal[1]) + " , ";
            dinnerLabel.Text = cntToBaseProd.prodView(login, typeofmeal[2]) + " , ";
            snackLabel.Text = cntToBaseProd.prodView(login, typeofmeal[3]) + " , ";
            supperLabel.Text = cntToBaseProd.prodView(login, typeofmeal[4]) + " , ";

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
            this.Close();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
        }
    }
}

