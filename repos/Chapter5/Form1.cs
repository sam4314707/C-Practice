using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace Chapter5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            double a;
            a = Abs(-3);
            textBox1.AppendText("Abs(-3) = " + a.ToString() + "\r\n");

        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            double a;
            a = Floor(3.7);
            textBox1.AppendText("Floor(3.7) = " + a.ToString() + "\r\n");
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            double a;
            a = Pow(2, 5);
            textBox1.AppendText("Pow(2, 5) = " + a.ToString() + "\r\n");
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            double a;
            a = Acos(0);
            textBox1.AppendText("Acos(0) = " + a.ToString() + "\r\n");
        }

        private void radioButton7_Click(object sender, EventArgs e)
        {
            double a;
            a = Ceiling(3.3);
            textBox1.AppendText("Ceiling(3.3) = " + a.ToString() + "\r\n");
        }

        private void radioButton10_Click(object sender, EventArgs e)
        {
            int a;
            a = DivRem(5, 3, out int r);
            textBox1.AppendText("5 / 3 = " + a.ToString() + "..." + r.ToString() + "\r\n");
        }

        private void radioButton13_Click(object sender, EventArgs e)
        {
            double a;
            a = Exp(0);
            textBox1.AppendText("Exp(0) = " + a.ToString() + "\r\n");
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            double a;
            a = Log(2);
            textBox1.AppendText("Log(2) = " + a.ToString() + "\r\n");
        }

        private void radioButton8_Click(object sender, EventArgs e)
        {
            double a;
            a = Log10(2);
            textBox1.AppendText("Log10(2) = " + a.ToString() + "\r\n");
        }

        private void radioButton11_Click(object sender, EventArgs e)
        {
            int a;
            a = Max(3, 10);
            textBox1.AppendText("Max(3, 10) = " + a.ToString() + "\r\n");
        }

        private void radioButton14_Click(object sender, EventArgs e)
        {
            int a;
            a = Min(3, 10);
            textBox1.AppendText("Min(3, 10) = " + a.ToString() + "\r\n");
        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            double a;
            a = Round(3.7);
            textBox1.AppendText("Round(3.7) = " + a.ToString() + "\r\n");
        }

        private void radioButton9_Click(object sender, EventArgs e)
        {
            int a;
            a = Sign(-2);
            textBox1.AppendText("Sign(-2) = " + a.ToString() + "\r\n");
        }

        private void radioButton12_Click(object sender, EventArgs e)
        {
            double a;
            a = Sqrt(2);
            textBox1.AppendText("Sqrt(2) = " + a.ToString() + "\r\n");
        }

        private void radioButton15_Click(object sender, EventArgs e)
        {
            double a;
            a = Truncate(2.7);
            textBox1.AppendText("Truncate(2.7) = " + a.ToString() + "\r\n");
        }
    }
}
