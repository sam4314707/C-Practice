using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter3
{
    public partial class Form1 : Form
    {
        int ans;
        string str;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ans = 0;
            for (int i = 1; i <= 10; i++)
            {
                str = "第" + i.ToString() + "次： " + ans.ToString();
                ans += i;
                str += " + " + i.ToString() + " = " + ans.ToString() + Environment.NewLine;

                textBox1.AppendText(str);
                
            }

            label2.Text = ans.ToString();
        }
    }
}
