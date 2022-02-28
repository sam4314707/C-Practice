using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MouseEventDemo
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Text = "MouseDown";
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            label2.Text = "MouseClick";
        }

        private void label2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label2.Text = "MouseDoubleClick";
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            ++count;
            label3.Text = Convert.ToString(count);
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.Text = "MouseHover";
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Thread.Sleep(500); // block the current thread.
            label1.Text = "label1";
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            Task.Delay(500).Wait(); // without block the current thread.
            label2.Text = "label2";
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            Task.Delay(500).Wait();
            label4.Text = "label4";
        }

        
    }
}
