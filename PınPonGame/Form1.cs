using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace PınPonGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer3.Enabled = true;
            timer5.Enabled = true;
        }
        private readonly Random r = new();
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = label1.Location.X;
            int y = label1.Location.Y;
            if (e.KeyCode == Keys.W)
            {
                y -= 20;
                label1.Location = new Point(x, y);
            }
            if (e.KeyCode == Keys.S)
            {
                y += 20;
                label1.Location = new Point(x, y);
            }
            int u = label2.Location.X;
            int ı = label2.Location.Y;
            if (e.KeyCode == Keys.Up)
            {
                ı -= 20;
                label2.Location = new Point(u, ı);
            }
            if (e.KeyCode == Keys.Down)
            {
                ı += 20;
                label2.Location = new Point(u, ı);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int top1 = r.Next(15, 30);
            pictureBox1.Left += top1;
            if (label2.Bottom >= pictureBox1.Top && label2.Top <= pictureBox1.Bottom && label2.Right >= pictureBox1.Left && label2.Left <= pictureBox1.Right)
            {
                timer1.Enabled = false; timer2.Enabled = true;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            int top1 = r.Next(15, 30);
            pictureBox1.Left -= top1;

            if (label1.Top <= pictureBox1.Bottom && label1.Bottom >= pictureBox1.Top && label1.Left <= pictureBox1.Right && label1.Right >= pictureBox1.Left)
            {
                timer2.Enabled = false; timer1.Enabled = true;
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            int top1 = r.Next(15, 30);
            pictureBox1.Top += top1;

            if (pictureBox1.Bottom > label5.Top)
            {
                timer3.Enabled = false; timer4.Enabled = true;
            }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            int top1 = r.Next(15, 30);
            pictureBox1.Top -= top1;

            if (pictureBox1.Top < label6.Bottom)
            {
                timer4.Enabled = false; timer3.Enabled = true;
            }
        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Left <= label4.Right)
            {
                timer5.Enabled = false;
                pictureBox1.Visible = false;
                _ = MessageBox.Show("2.Cİ OYUNCU KAZANDI EZZ");//YANMA
            }
            if (pictureBox1.Right >= label3.Left)
            {
                timer5.Enabled = false; pictureBox1.Visible = false; _ = MessageBox.Show("1.Cİ OYUNCU KAZANDI EZZ");//YANMA
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", "-r -t 00");
        }
    }
}