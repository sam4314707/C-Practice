using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadomAlphabet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            StringBuilder str = new StringBuilder();

            textBox1.Clear();

            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    int fg = rd.Next(1, 3);
                    if (fg == 1)
                    {
                        str.Append(Convert.ToChar(rd.Next(65, 91)).ToString());
                    }
                    else if (fg == 2)
                    {
                        str.Append(Convert.ToChar(rd.Next(97, 123)).ToString());
                    }

                        
                }

                textBox1.AppendText(str.ToString() + " ");
                str.Clear();
            }

        }
    }
}
