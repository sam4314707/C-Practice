using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculater
{
    public partial class Form1 : Form
    {
        float height, weight;

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            double bmi;

            height = Convert.ToSingle(TextBpxHeight.Text);
            weight = Convert.ToSingle(TextBoxWeight.Text);

            bmi = Math.Round(weight / Math.Pow(height / 100, 2), 2);

            OutputLabel.Text = "BMI = " + Convert.ToString(bmi);
        }

        public Form1()
        {
            InitializeComponent();
        }



    }
}
