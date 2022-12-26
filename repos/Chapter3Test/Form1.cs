using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter3Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 5; i > 0; i = i - 2)
            {
                int tmp = 0;
                for (int j = 1; j < i; j++)
                {
                    textBox1.AppendText(" ");
                    tmp = j;
                }
                for (int k = 1; k + tmp < 6; k++)
                {
                    textBox1.AppendText("*");
                }
                textBox1.AppendText("\r\n");
            }
        }
    }
}
