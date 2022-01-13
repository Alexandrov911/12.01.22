using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._01._2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.BackColor = colorDialog1.Color;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            //Pen p = new Pen(Color.Black);
            Pen p = new Pen(pictureBox3.BackColor);

            //SolidBrush b = new SolidBrush(Color.Yellow);
            SolidBrush b = new SolidBrush(pictureBox2.BackColor);
            int x = Convert.ToInt32(numericUpDown1.Value);
            int y = Convert.ToInt32(numericUpDown2.Value);
            int h = Convert.ToInt32(numericUpDown3.Value);
            int w = Convert.ToInt32(numericUpDown4.Value);
            g.FillRectangle(b, x, y, w, h);
            g.DrawRectangle(p, x, y, w, h);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            //Pen p = new Pen(Color.Black);
            Pen p = new Pen(pictureBox3.BackColor);
            p.Width = 5;
            //SolidBrush b = new SolidBrush(Color.Yellow);
            SolidBrush b = new SolidBrush(pictureBox2.BackColor);
            int x = Convert.ToInt32(numericUpDown1.Value);
            int y = Convert.ToInt32(numericUpDown2.Value);
            int h = Convert.ToInt32(numericUpDown4.Value);
            int w = Convert.ToInt32(numericUpDown3.Value);
            g.FillEllipse(b, x, y, w, h);
            g.DrawEllipse(p, x, y, w, h);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.BackColor = colorDialog1.Color;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = 100;
            numericUpDown2.Value = 200;
            numericUpDown3.Value = 200;
            numericUpDown4.Value = 200;
            numericUpDown5.Value = 4;
            pictureBox2.BackColor = Color.White;
            pictureBox3.BackColor = Color.Black;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = new Bitmap(pictureBox4.Width, pictureBox4.Height);
            Graphics g = Graphics.FromImage(pictureBox4.Image);
            SolidBrush b = new SolidBrush(Color.Yellow);
            int h = 200;
            g.FillEllipse(b, 100, 100, h, h);
            SolidBrush b2 = new SolidBrush(Color.Black);
            g.FillEllipse(b2, 100 + h / 2 - 20 - h / 8, 100 + h / 4, 20, 20);
            g.FillEllipse(b2, 100 + h / 2 + h / 8, 100 + h / 4, 20, 20);
            SolidBrush b3 = new SolidBrush(Color.Red);
            g.FillEllipse(b3, 100 + h / 2 - 20 - h / 8, 100 + h / 2 + h / 8, 20 + 20 + h / 8 + h / 8, 15);
            SolidBrush b4 = new SolidBrush(Color.Black);
            g.FillRectangle(b4, 100 + h / 4, 100 + h / 6, 30, 5);
            g.FillRectangle(b4, 100 + 120, 100 + h / 6, 30, 5);

        }
    }
}
