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
    public partial class accountInfo : Form
    {
        public accountInfo()
        {
            InitializeComponent();
            userService newservice = new userService();
            loginBox loginbox = new loginBox();

            string login = loginBox.userLoginDisplay;

            newservice.completingTheInfoAboutUser(login);

           

            //int userAgeLabel = Convert.ToInt32(ageLabel.Text);
            //int userWeightLabel = Convert.ToInt32(weightLabel.Text);
            //int userHeightLabel = Convert.ToInt32(heightLabel.Text);

            //newservice.completingTheInfoAboutUser(login, nameTextLabel.Text, lastNameTextLabel.Text, emailLabel.Text, userAgeLabel, userWeightLabel, userHeightLabel);
            //nameTextLabel.Text = newservice.getUserLogin(login);
        }

        //public void completeAllData(string name, string lastname, string email, int age, int weight, int height)
        //{
        //    double bmrCalculated = (10 * weight) + (6.25 * height) - (5 * age) + 5;
        //    double BmiCalculated = weight / ((height * height) / 10000);

        //    nameTextLabel.Text = name;
        //    lastNameTextLabel.Text = lastname;
        //    emailLabel.Text = email;
        //    ageLabel.Text = age.ToString();
        //    weightLabel.Text = weight.ToString();
        //    heightLabel.Text = height.ToString();
        //    bmrTextLabel.Text = bmrCalculated.ToString();
        //    bmiTextLabel.Text = BmiCalculated.ToString();
        //}

        private void returnMainboxButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainBox mainMenuBox = new mainBox();
            mainMenuBox.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
