using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            Random rnd = new Random();

            int x_random;
            int y_random;

            Graphics nowy = e.Graphics;

            for (int i = 0; i < 80; i++)
            {
                x_random = rnd.Next(5, 760);
                y_random = rnd.Next(5, 395);
                nowy.FillRectangle(Brushes.Yellow, x_random, y_random, 5, 5);
            }

            for (int i = 0; i < 70; i++)
            {
                x_random = rnd.Next(5, 760);
                y_random = rnd.Next(5, 395);
                nowy.FillRectangle(Brushes.White, x_random, y_random, 5, 5);
            }




            int y = 20;
            int x = 55;
            int yU = 20;
            int yA = 20;
            for (int i = 0; i < 7; i++) //doing L
            {
                e.Graphics.FillRectangle(Brushes.DodgerBlue, 25, y, 30, 30);
                e.Graphics.FillRectangle(Brushes.DodgerBlue, 165, yU, 30, 30);
                e.Graphics.FillRectangle(Brushes.DodgerBlue, 255, yU, 30, 30);
                e.Graphics.FillRectangle(Brushes.DodgerBlue, 315, yA, 30, 30);
                e.Graphics.FillRectangle(Brushes.DodgerBlue, 420, yA, 30, 30);
                yA += 30;
                yU += 30;
                y += 30;
            }

            int xA = 345;
            int xS = 345;
            int yS = 50;
            int ySone = 140;
            for (int i = 0; i < 3; i++) //doing L
            {
                e.Graphics.FillRectangle(Brushes.DodgerBlue, x, 200, 30, 30);
                e.Graphics.FillRectangle(Brushes.DodgerBlue, xA, 20, 30, 30);
                e.Graphics.FillRectangle(Brushes.DodgerBlue, xA, 120, 30, 30);
                e.Graphics.FillRectangle(Brushes.DodgerBlue, xS, 120, 30, 30);
                e.Graphics.FillRectangle(Brushes.DodgerBlue, 480, yS, 30, 30);
                e.Graphics.FillRectangle(Brushes.DodgerBlue, 570, ySone, 30, 30);
                xS += 30;
                yS += 30;
                ySone += 30;
                xA += 24;
                x += 25;
            }

            e.Graphics.FillRectangle(Brushes.DodgerBlue, 195, 200, 30, 30);  //doing U
            e.Graphics.FillRectangle(Brushes.DodgerBlue, 225, 200, 30, 30);  //doing U

            int xS_one = 480;
            for (int i = 0; i < 4; i++)
            {
                e.Graphics.FillRectangle(Brushes.DodgerBlue, xS_one, 20, 30, 30);
                e.Graphics.FillRectangle(Brushes.DodgerBlue, xS_one, 110, 30, 30);
                e.Graphics.FillRectangle(Brushes.DodgerBlue, xS_one, 200, 30, 30);
                xS_one += 30;
            }



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
