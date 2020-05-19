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

            List<string> typesofmeal = new List<string>();
            typesofmeal.Add("Breakfast");
            typesofmeal.Add("Second Breakfast");
            typesofmeal.Add("Dinner");
            typesofmeal.Add("Snack");
            typesofmeal.Add("Supper");

            typeOfMealBox.Text = "Chose one";

            foreach(string type in typesofmeal)
            {
                typeOfMealBox.Items.Add(type);
            }
            

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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string selectedTypeOfMeal = typeOfMealBox.SelectedItem.ToString();
            DateTime thisDay = DateTime.Today;
            string cur_date = thisDay.ToString("d");

            loginBox loginbox = new loginBox();
            string login = loginBox.userLoginDisplay;

            DialogResult res = MessageBox.Show("Are you sure you want to Add", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(res == DialogResult.OK)
            {
                connectToBaseProduct cntToBaseProd = new connectToBaseProduct();
                var item = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                
                var itemCalories = dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                var itemProteins = dataGridView1.Rows[e.RowIndex].Cells[2].Value;
                var itemFats = dataGridView1.Rows[e.RowIndex].Cells[3].Value;
                var itemCarbs = dataGridView1.Rows[e.RowIndex].Cells[4].Value;

                cntToBaseProd.addingProdToMeal(item.ToString(), login, selectedTypeOfMeal ,cur_date, itemCalories.ToString(), itemProteins.ToString(), itemFats.ToString(), itemCarbs.ToString());

                this.Close();
                mainBox mainbox = new mainBox();
                mainbox.Show();
            }
            else
            {
                MessageBox.Show("Nothing choose");
            }  
        }

       
        


    }
}
