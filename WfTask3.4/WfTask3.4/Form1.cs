using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfTask3._4
{
    public partial class Form1 : Form
    {

        Graphics g;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void drawFunc_Click(object sender, EventArgs e)
        {

            background();

            string x0Temp, y0Temp, x1Temp, y1Temp;
            int x0, y0, x1, y1;

            Pen blackPen = new Pen(Color.Black);

            x0Temp = xZeroTextBox.Text;
            y0Temp = yZeroTextBox.Text;
            x1Temp = xOneTextBox.Text;
            y1Temp = yOneTextBox.Text;

            if (y0Temp == "")
            {
                MessageBox.Show(
                "Enter Y0",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);;

                yZeroTextBox.Text = "0";
            }
            if (x0Temp == "")
            {
                    MessageBox.Show(
                    "Enter X0",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly); ;

                xZeroTextBox.Text = "0";
            }
            if (x1Temp == "")
            {
                MessageBox.Show(
                "Enter X1",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly); ;

                xOneTextBox.Text = "0";
            }
            if (y1Temp == "")
            {
                MessageBox.Show(
                "Enter Y1",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly); ;

                yOneTextBox.Text = "0";
            }



            x0 = Convert.ToInt32(x0Temp);
            y0 = Convert.ToInt32(y0Temp);
            x1 = Convert.ToInt32(x1Temp);
            y1 = Convert.ToInt32(y1Temp);


            g.DrawLine(blackPen, changeX(x0), changeY(y0),
                changeX(x1), changeY(y1));

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void background()
        {
            g = CreateGraphics();
            g.Clear(Color.White);

            Pen p1 = new Pen(Color.Black);
            Brush b1 = new SolidBrush(Color.LightGray);
            int H = Form1.ActiveForm.Size.Height;
            int W = Form1.ActiveForm.Size.Width;
            int c_x = W / 2;
            int c_y = H / 2;
            g.FillRectangle(b1, 0, 0, W, H); 
            g.DrawLine(p1, c_x, 0, c_x, H);
            g.DrawLine(p1, 0, c_y, W, c_y);
        }

        private int changeX(int x)
        {
            int W = Form1.ActiveForm.Size.Width;
            int c_x = W / 2;
            x = c_x + x;
            return x;
        }
        private int changeY(int y)
        {
            int H = Form1.ActiveForm.Size.Height;
            int c_y = H / 2;
            y = c_y - y;
            return y;
        }

        private void rotate(int x1, int y1, int x2, int y2, double f)
        {
            Pen blackPen = new Pen(Color.Black);
            g = CreateGraphics();
            g.Clear(Color.White);

           
            Brush b1 = new SolidBrush(Color.LightGray);
            int H = Form1.ActiveForm.Size.Height;
            int W = Form1.ActiveForm.Size.Width;
            int c_x = W / 2;
            int c_y = H / 2;
            g.FillRectangle(b1, 0, 0, W, H);
            g.DrawLine(blackPen, c_x, 0, c_x, H);
            g.DrawLine(blackPen, 0, c_y, W, c_y);




            double[,] mass = new double[2, 2];
            mass[0, 0] = x1;
            mass[0, 1] = y1;
            mass[1, 0] = x2;
            mass[1, 1] = y2;

            double[,] Mass = new double[2, 2];
            Mass[0, 0] = Math.Cos(f);
            Mass[0, 1] = Math.Sin(f);
            Mass[1, 0] = -Math.Sin(f);
            Mass[1, 1] = Math.Cos(f);

            double[,] mass3 = new double[2, 2]; 
            double sum = 0;
            for (int i = 0; i < 2; i++)  
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int r = 0; r < 2; r++)
                    {
                        sum = sum + mass[i, r] * Mass[r, j];
                    }
                    mass3[i, j] = sum;
                    sum = 0;
                }
            }
            x1 = Convert.ToInt32(mass3[0, 0]);
            y1 = Convert.ToInt32(mass3[0, 1]);
            x2 = Convert.ToInt32(mass3[1, 0]);
            y2 = Convert.ToInt32(mass3[1, 1]);
            g.DrawLine(blackPen, changeX(x1), changeY(y1),
                changeX(x2), changeY(y2)); 

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rotateLine_Click(object sender, EventArgs e)
        {
            string x0Temp, y0Temp, x1Temp, y1Temp,angleTemp;
            int x0, y0, x1, y1;
            double angle;

            

            x0Temp = xZeroTextBox.Text;
            y0Temp = yZeroTextBox.Text;
            x1Temp = xOneTextBox.Text;
            y1Temp = yOneTextBox.Text;
            angleTemp = rotateAngle.Text;

            x0 = Convert.ToInt32(x0Temp);
            y0 = Convert.ToInt32(y0Temp);
            x1 = Convert.ToInt32(x1Temp);
            y1 = Convert.ToInt32(y1Temp);
            angle = Convert.ToDouble(angleTemp);

            rotate(x0, y0, x1, y1, angle);
        }
    }
}
