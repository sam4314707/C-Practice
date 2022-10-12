using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalAvgApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ans;
            double n1, n2, n3;
            n1 = Convert.ToDouble(textBoxNum1.Text);
            n2 = Convert.ToDouble(textBoxNum2.Text);
            n3 = Convert.ToDouble(textBoxNum3.Text);

            ans = (n1 + n2 + n3) / 3;
            label4.Text = Convert.ToString(ans);
            label4.Visible = true;
        }
    }
}
