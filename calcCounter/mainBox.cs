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
    }
}
