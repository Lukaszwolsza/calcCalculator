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
    public partial class productBox : Form
    {
        public productBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void returnMainboxButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainBox mainMenuBox = new mainBox();
            mainMenuBox.Show();
        }

        private void mainFormExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewProdBtn_Click(object sender, EventArgs e)
        {
            string prodName = productText.Text;
            double prodCalories = Convert.ToDouble(caloriesText.Text);
            double prodProtein = Convert.ToDouble(proteinText.Text);
            double prodFat = Convert.ToDouble(fatText.Text);
            double prodCarbs = Convert.ToDouble(carbText.Text);

            productService prodservice = new productService();

            prodservice.addProductToList(prodName, prodCalories, prodProtein, prodFat, prodCarbs);

            MessageBox.Show("You've added " + prodName + " to base ! ");

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
    }
}
