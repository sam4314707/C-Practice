using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobConditionsFilter
{
    public partial class Form1 : Form
    {
        int gender = 0;
        bool fgVel = false;
        bool fgHDC = false;
        int age = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                age = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("輸入錯誤");
                textBox1.Text = "0";
                return;
            }

            if (gender == 0)
            {
                if(age < 20 || age > 35)
                {
                    MessageBox.Show("年齡不符");
                }
                else
                {
                    if (fgVel == true)
                        MessageBox.Show("符合");
                    else
                        MessageBox.Show("無自備交通工具，資格不符");
                }
            }
            else
            {
                if(fgHDC == false)
                {
                    MessageBox.Show("尚未役畢，資格不符");
                }
                else
                {
                    if(fgVel == true)
                    {
                        MessageBox.Show("資格符合");
                    }
                    else
                    {
                        MessageBox.Show("無自備交通工具，資格不符");
                    }
                }
            }

        }

        private void radioButtonMale_Click(object sender, EventArgs e)
        {
            gender = 1;
            groupBox3.Visible = true;
        }

        private void radioButtonFemale_Click(object sender, EventArgs e)
        {
            gender = 0;
            groupBox3.Visible = false;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            fgHDC = true;
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            fgHDC = false;
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            fgVel = true;
        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            fgVel = false;
        }
    }
}
