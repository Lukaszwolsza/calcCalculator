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
    public partial class copyrightsBox : Form
    {
        public copyrightsBox()
        {
            InitializeComponent();
        }

        private void copyrightsBox_Load(object sender, EventArgs e)
        {
            
        }

        private void copyrightsBox_Paint(object sender, PaintEventArgs e)
        {
            


        }

        private void loginBoxExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void returnMainboxButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainBox mainMenuBox = new mainBox();
            mainMenuBox.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
