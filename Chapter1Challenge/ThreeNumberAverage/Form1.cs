using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeNumberAverage
{
    public partial class Form1 : Form
    {
        double n1, n2, n3;
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            double ans;
            double[] array;

            n1 = Convert.ToDouble(textBoxN1.Text);
            n2 = Convert.ToDouble(textBoxN2.Text);
            n3 = Convert.ToDouble(textBoxN3.Text);

            array = new double[] { n1, n2, n3 };

            ans = Math.Round(Queryable.Average(array.AsQueryable()), 2);

            Output.Text = "ans = " + Convert.ToString(ans);
        }
    }
}
