using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoRandomMaker
{
    public partial class Form1 : Form
    {
        Random rd1, rd2;
        public Form1()
        {
            InitializeComponent();
            rd1 = new Random();
            System.Threading.Thread.Sleep(100);
            Refresh();
            rd2 = new Random();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            for (int i = 0; i < 5; i++)
            {
                textBox1.AppendText("mk1: " + rd1.Next(15, 40).ToString() + "\r\n");
                
                textBox1.AppendText("mk2: " + rd2.Next(15, 40).ToString() + "\r\n");
            }
        }
    }
}
