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

namespace RGBTextBox
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            textBox1.BackColor = Color.FromArgb(0, 0, 0);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 255; i++)
            {
                textBox1.BackColor = Color.FromArgb(i, 0, 0);
                Refresh();
                Thread.Sleep(10);
            }
            for (int i = 0; i < 255; i++)
            {
                textBox1.BackColor = Color.FromArgb(255 - i, i, 0);
                Refresh();
                Thread.Sleep(10);
            }
            for (int i = 0; i < 255; i++)
            {
                textBox1.BackColor = Color.FromArgb(0, 255 - i, i);
                Refresh();
                Thread.Sleep(10);
            }


        }


    }
}
