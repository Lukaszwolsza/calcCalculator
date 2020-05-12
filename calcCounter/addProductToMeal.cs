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
    public partial class addProductToMeal : Form
    {
        public addProductToMeal()
        {
            InitializeComponent();
        }

        private void addProductToMeal_Load(object sender, EventArgs e)
        {
            connectToBaseProduct cntToBaseProd = new connectToBaseProduct();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = cntToBaseProd.displayingProducts();
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

        private void searchProdButton_Click(object sender, EventArgs e)
        {
            string searchedProd = searchedProductInput.Text;
            connectToBaseProduct cntToBaseProd = new connectToBaseProduct();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = cntToBaseProd.searchingProduct(searchedProd);
        }

        private void addNewProdBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
