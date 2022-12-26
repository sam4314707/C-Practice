using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrianglePrinter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    textBox1.AppendText("*");
                }
                textBox1.AppendText(Environment.NewLine);
            }

            for (int i = 0; i < 4; i++)
            {
                textBox1.AppendText(Environment.NewLine);
            }

            for (int i = 1; i < 6; i++)
            {
                if(i == 3)
                {
                    i++;
                }
                for (int j = 1; j < i; j++)
                {
                    textBox1.AppendText("  ");
                }
                for (int k = 0; k < 6 - i; k++)
                {
                    textBox1.AppendText("*");
                }
                textBox1.AppendText(Environment.NewLine);
            }
        }
    }
}
