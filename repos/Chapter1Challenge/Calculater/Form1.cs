using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculater
{
    public partial class Form1 : Form
    {
        float n1, n2;
        public Form1()
        {
            InitializeComponent();
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            float ans;

            n1 = Convert.ToSingle(textBoxn1.Text);
            n2 = Convert.ToSingle(textBoxn2.Text);

            ans = n1 - n2;

            labelAns.Text = "Ans:" + Convert.ToString(ans);
        }

        private void MultipBtn_Click(object sender, EventArgs e)
        {
            float ans;

            n1 = Convert.ToSingle(textBoxn1.Text);
            n2 = Convert.ToSingle(textBoxn2.Text);

            ans = n1 * n2;

            labelAns.Text = "Ans:" + Convert.ToString(ans);
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            float ans;

            n1 = Convert.ToSingle(textBoxn1.Text);
            n2 = Convert.ToSingle(textBoxn2.Text);

            ans = n1 / n2;

            labelAns.Text = "Ans:" + Convert.ToString(ans);
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            float ans;

            n1 = Convert.ToSingle(textBoxn1.Text);
            n2 = Convert.ToSingle(textBoxn2.Text);

            ans = n1 + n2;

            labelAns.Text = "Ans:" + Convert.ToString(ans);
        }
    }
}
