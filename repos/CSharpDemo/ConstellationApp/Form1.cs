using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstellationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month, day;

            try
            {
                month = Convert.ToInt32(textBox1.Text);
                day = Convert.ToInt32(textBox2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("輸入錯誤");
                return;
            }

            if (month < 1 || month > 12)
            {
                MessageBox.Show("輸入1-12月");
                return;
            }

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (day < 1 || day > 31)
                    {
                        MessageBox.Show("日期有誤");
                        return;
                    }
                    break;
            }

            switch (month)
            {
                case 2:
                    if(day < 1 || day > 28)
                    {
                        MessageBox.Show("日期有誤");
                        return;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (day < 1 || day > 30)
                    {
                        MessageBox.Show("日期有誤");
                        return;
                    }
                    break;
            }


            switch (month)
            {
                case 1:
                    if (day < 21)
                    {
                        label3.Text = "Capricornus";
                    }
                    else
                    {
                        label3.Text = "Aquarius";
                    }
                    break;
                case 2:
                    if (day < 20)
                    {
                        label3.Text = "Aquarius";
                    }
                    else
                    {
                        label3.Text = "Pisces";
                    }
                    break;
                case 3:
                    if (day < 21)
                    {
                        label3.Text = "Pisces";
                    }
                    else
                    {
                        label3.Text = "Aries";
                    }
                    break;
                case 4:
                    if (day < 20)
                    {
                        label3.Text = "Aries";
                    }
                    else
                    {
                        label3.Text = "Taurus";
                    }
                    break;
                case 5:
                    if (day < 21)
                    {
                        label3.Text = "Taurus";
                    }
                    else
                    {
                        label3.Text = "Gemini";
                    }
                    break;
                case 6:
                    if (day < 22)
                    {
                        label3.Text = "Gemini";
                    }
                    else
                    {
                        label3.Text = "Cancer";
                    }
                    break;
                case 7:
                    if (day < 23)
                    {
                        label3.Text = "Cancer";
                    }
                    else
                    {
                        label3.Text = "Leo";
                    }
                    break;
                case 8:
                    if (day < 23)
                    {
                        label3.Text = "Leo";
                    }
                    else
                    {
                        label3.Text = "Virgo";
                    }
                    break;
                case 9:
                    if (day < 23)
                    {
                        label3.Text = "Virgo";
                    }
                    else
                    {
                        label3.Text = "Libra";
                    }
                    break;
                case 10:
                    if (day < 24)
                    {
                        label3.Text = "Libra";
                    }
                    else
                    {
                        label3.Text = "Scorpio";
                    }
                    break;
                case 11:
                    if (day < 22)
                    {
                        label3.Text = "Scorpio";
                    }
                    else
                    {
                        label3.Text = "Sagittarius";
                    }
                    break;
                case 12:
                    if (day < 21)
                    {
                        label3.Text = "Sagittarius";
                    }
                    else
                    {
                        label3.Text = "Capricornus";
                    }
                    break;


            }

        }
    }
}
