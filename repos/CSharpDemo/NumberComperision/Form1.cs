using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberComperision
{
    public partial class Form1 : Form
    {
        int n1, n2, n3;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                n1 = Convert.ToInt32(textBox1.Text);
                n2 = Convert.ToInt32(textBox2.Text);
                n3 = Convert.ToInt32(textBox3.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("輸入錯誤請重新輸入");
            }

            if(n1 > n2 && n1 > n3)
            {
                if(n2 > n3)
                {
                    textBox4.AppendText(n1 + ">" + n2 + ">" + n3 + "\r\n");
                }
                else
                {
                    textBox4.AppendText(n1 + ">" + n3 + ">" + n2 + "\r\n");
                }
            }else if(n2 > n1 && n2 > n3)
            {
                if (n1 > n3)
                {
                    textBox4.AppendText(n2 + ">" + n1 + ">" + n3 + "\r\n");
                }
                else
                {
                    textBox4.AppendText(n2 + ">" + n3 + ">" + n1 + "\r\n");
                }
            }
            else
            {
                if (n1 > n3)
                {
                    textBox4.AppendText(n3 + ">" + n1 + ">" + n2 + "\r\n");
                }
                else
                {
                    textBox4.AppendText(n3 + ">" + n2 + ">" + n1 + "\r\n");
                }
            }


        }
    }
}
