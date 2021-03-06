﻿using System;
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
    public partial class accountInfo : Form
    {
        public accountInfo()
        {
            InitializeComponent();
            //userService newservice = new userService();
            loginBox loginbox = new loginBox();

            string login = loginBox.userLoginDisplay;

            // LIST OLD
            //newservice.completingTheInfoAboutUser(login);
        }

        public double getUserBMR(int age, int weight, int height)
        {
            double bmrCalculated = (10 * weight) + (6.25 * height) - (5 * age) + 5;
            return bmrCalculated;
        }

        public void completeAllData(string name, string lastname, string email, int age, int weight, int height)
        {
            double bmrCalculated = getBMR();
            double BmiCalculated = getBMI();

            nameTextLabel.Text = name;
            lastNameTextLabel.Text = lastname;
            emailLabel.Text = email;
            ageLabel.Text = age.ToString();
            weightLabel.Text = weight.ToString();
            heightLabel.Text = height.ToString();

            bmrTextLabel.Text = bmrCalculated.ToString();
            bmiTextLabel.Text = BmiCalculated.ToString();
        }

        private void returnMainboxButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainBox mainMenuBox = new mainBox();
            mainMenuBox.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public double getBMI()
        {
            // <LIST> CONNECTION
            //userService newservice = new userService();
            loginBox loginbox = new loginBox();
            connectToBaseUser cntToBaseUser = new connectToBaseUser();

            double BmiCalculated = 0;
            string login = loginBox.userLoginDisplay;

            string gender = cntToBaseUser.userGender(login);

            double weight = cntToBaseUser.userWeight(login);
            double height = cntToBaseUser.userHeight(login);
            double age = cntToBaseUser.userAge(login);


            BmiCalculated = Math.Round(weight / ((height * height) / 10000), 3);
            
            return BmiCalculated;
        }

        public double getBMR()
        {
            // <LIST> CONNECTION
            //userService newservice = new userService();
            loginBox loginbox = new loginBox();
            connectToBaseUser cntToBaseUser = new connectToBaseUser();

            double bmrCalculated = 0;
            string login = loginBox.userLoginDisplay;

            string gender = cntToBaseUser.userGender(login);
            double weight = cntToBaseUser.userWeight(login);
            double height = cntToBaseUser.userHeight(login);
            double age = cntToBaseUser.userAge(login);

            if (gender == "F")
            {
                bmrCalculated = Math.Round((10 * weight) + (6.25 * height) - (5 * age) - 161, 3);
            }
            else if (gender == "M")
            {
                bmrCalculated = Math.Round((10 * weight) + (6.25 * height) - (5 * age) + 5, 3);
            }
            return bmrCalculated;
        }

        private void accountInfo_Load(object sender, EventArgs e)
        {
            // <LIST> CONNECTION
            //userService newservice = new userService();

            loginBox loginbox = new loginBox();
            connectToBaseUser cntToBaseUser = new connectToBaseUser();
           
            string login = loginBox.userLoginDisplay;
            double weight = cntToBaseUser.userWeight(login);
            double height = cntToBaseUser.userHeight(login);
            double age = cntToBaseUser.userAge(login);
            

            if(getBMI() < 16)
            {
                statusOfBmiLabel.Text = "Very severely underweight";
            }
            else if(getBMI() <= 16.99)
            {
                statusOfBmiLabel.Text = "Severely underweight";
            }
            else if(getBMI() <= 18.49)
            {
                statusOfBmiLabel.Text = "Underweight";
            }
            else if (getBMI() <= 24.99)
            {
                statusOfBmiLabel.Text = "Normal (healthy weight)";
            }
            else if (getBMI() <= 29.99)
            {
                statusOfBmiLabel.Text = "Overweight";
            }
            else if (getBMI() <= 34.99)
            {
                statusOfBmiLabel.Text = "Obese Class I";
            }
            else if (getBMI() <= 39.99)
            {
                statusOfBmiLabel.Text = "Obese Class II";
            }
            else if (getBMI() > 40)
            {
                statusOfBmiLabel.Text = "Obese Class III";
            }

            nameTextLabel.Text = cntToBaseUser.userName(login);
            lastNameTextLabel.Text = cntToBaseUser.userLastName(login);
            emailLabel.Text = cntToBaseUser.userEmail(login);
            ageLabel.Text = age.ToString();
            weightLabel.Text = weight.ToString() + " kg";
            heightLabel.Text = height.ToString() + " cm";
            genderTextLabel.Text = cntToBaseUser.userGender(login);
            bmrTextLabel.Text = getBMR().ToString() + " kcal/day";
            bmiTextLabel.Text = getBMI().ToString();

        }

        private void mainFormExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yellowMinimalizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitRedButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        Point lastPoint;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
