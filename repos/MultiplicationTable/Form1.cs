using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplicationTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ans;
            string str;
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    str = i.ToString() + " * " + j.ToString() + " = " + Convert.ToString(i * j) + "  \t";
                    textBox1.AppendText(str);

                }

                textBox1.AppendText(Environment.NewLine);
            }
        }
    }
}
