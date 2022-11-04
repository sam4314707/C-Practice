using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeJudge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonjudge_Click(object sender, EventArgs e)
        {
            /*int age = Convert.ToInt32(textBoxAge.Text);

            if(age < 18)
            {
                MessageBox.Show("不能買酒!");
            }
            else
            {
                label2.Visible = true;
                textBoxBQ.Visible = true;
                button1.Visible = true;
                label3.Visible = true;
            }
            */

            int age;

            try
            {
                age = Convert.ToInt32(textBoxAge.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
                MessageBox.Show("輸入錯誤，重新輸入!");
                textBoxAge.Text = "";
                return;
            }

            if (age <= 18)
            {
                MessageBox.Show("未成年請勿飲酒");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total;
            total = 32 * Convert.ToInt32(textBoxBQ.Text);
            label3.Text = "共 " + total + " 元";
        }

        private void textBoxBQ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int total;
                total = 32 * Convert.ToInt32(textBoxBQ.Text);
                label3.Text = "共 " + total + " 元";
            }
        }

        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (e.KeyChar == (char)48 || e.KeyChar == (char)49 || e.KeyChar == (char)50 ||
                e.KeyChar == (char)51 || e.KeyChar == (char)52 || e.KeyChar == (char)53 ||
                e.KeyChar == (char)54 || e.KeyChar == (char)55 || e.KeyChar == (char)56 ||
                e.KeyChar == (char)57 || e.KeyChar == (char)13 || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else // 不是的話，把其餘按鍵設定為已經處理過了
            {
                e.Handled = true;
            }*/
        }
    }
}
