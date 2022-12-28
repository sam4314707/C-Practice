using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RightShiftOperation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShiftBtn_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt16(textBox1.Text);
            int n2 = Convert.ToInt16(textBox2.Text);
            int ans = n1 >> Convert.ToInt16(Math.Log(n2,2));
            ans += 10;

            label3.Text = "Ans :" + Convert.ToString(ans);
        }
    }
}
