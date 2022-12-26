using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContinueBreakDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                int con = Convert.ToInt32(textBox1.Text);
                int sum = 0;
                string str;
                for (int i = 1; i < 11; i++)
                {
                    if (i == con)
                    {
                        continue;
                    }
                    sum += i;
                    str = "i = ";
                    str += i.ToString() + " , sum = ";
                    str += sum.ToString();

                    textBox3.AppendText(str);
                    textBox3.AppendText("\r\n");

                }
            }
            else if (radioButton2.Checked == true)
            {
                int con = Convert.ToInt32(textBox2.Text);
                int sum = 0;
                string str;
                for (int i = 1; i < 11; i++)
                {
                    if (i == con)
                    {
                        break;
                    }
                    sum += i;
                    str = "i = ";
                    str += i.ToString() + " , sum = ";
                    str += sum.ToString();

                    textBox3.AppendText(str);
                    textBox3.AppendText("\r\n");

                }
            }
        }
    }
}
