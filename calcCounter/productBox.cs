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
    public partial class productBox : Form
    {
        public productBox()
        {
            InitializeComponent();
        }

        

        //public void searchingProduct(string prodName)
        //{
        //    string sqlStringConnector = "Server =.\\SQLEXPRESS; Database = FatToFit; Trusted_Connection = True;";
        //    using (var sqlConnection = new SqlConnection(sqlStringConnector))
        //    {
        //        sqlConnection.Open();
        //        if (prodName == "")
        //        {
        //            SqlDataAdapter sqlDa = new SqlDataAdapter($"SELECT * FROM dbo.products", sqlConnection);
        //            DataTable dtbl = new DataTable();
        //            sqlDa.Fill(dtbl);
        //            dataGridView1.AutoGenerateColumns = false;
        //            dataGridView1.DataSource = dtbl;
        //        }
        //        else
        //        {
        //            SqlDataAdapter sqlDa = new SqlDataAdapter($"SELECT * FROM dbo.products WHERE NAME = '{prodName}'", sqlConnection);
        //            DataTable dtbl = new DataTable();
        //            sqlDa.Fill(dtbl);
        //            dataGridView1.AutoGenerateColumns = false;
        //            dataGridView1.DataSource = dtbl;
        //        }
        //    }
        //}



        public string getSearchingItem()
        {
            return searchedItem.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchedItem = getSearchingItem();
            connectToBaseProduct cntToBaseProd = new connectToBaseProduct();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = cntToBaseProd.searchingProduct(searchedItem);
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

            //productService prodservice = new productService();

            //prodservice.addProductToList(prodName, prodCalories, prodProtein, prodFat, prodCarbs);

            //MessageBox.Show("You've added " + prodName + " to base ! ");

            connectToBaseProduct cntToBase = new connectToBaseProduct();
            cntToBase.addProductToBase(prodName, prodCalories, prodProtein, prodFat, prodCarbs);
            MessageBox.Show("You've added " + prodName + " to base ! ");

            // CZYSZCZENIE FORMA PO DODANIU 
            productText.Clear();
            caloriesText.Clear();
            proteinText.Clear();
            fatText.Clear();
            carbText.Clear();
            dataGridView1.Refresh();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connectToBaseProduct cntToBaseProd = new connectToBaseProduct();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = cntToBaseProd.displayingProducts();
        }

        private void productBox_Load(object sender, EventArgs e)
        {
            connectToBaseProduct cntToBaseProd = new connectToBaseProduct();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = cntToBaseProd.displayingProducts();
        }
    }
}
