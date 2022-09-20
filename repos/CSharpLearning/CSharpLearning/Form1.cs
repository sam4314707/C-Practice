using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLearning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void buttoncal_Click(object sender, EventArgs e)
        {
            double weight;
            double height;
            double ans;

            height = Convert.ToDouble(textBoxheight.Text);
            weight = Convert.ToDouble(textBoxweight.Text);
            ans = Math.Round(weight / Math.Pow(height, 2), 2);
            labelAns.Text = "你的BMI是  " + Convert.ToString(ans);

            labelAns.Visible = true;
        }
    }
}
