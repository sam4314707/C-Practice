using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneToA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            int a, ans = 0;
            string str = "";

            a = Convert.ToInt32(textBox1.Text);

            for (int i = 1; i <= a; i++)
            {
                str = ans.ToString() + " + " + i.ToString() + " = ";
                ans += i;
                str += ans.ToString();
                textBox2.AppendText(str + "\r\n");
            }
        }
    }
}
