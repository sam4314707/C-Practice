using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConversion_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CtoF_Click(object sender, EventArgs e)
        {
            float cTemp, fTemp;

            cTemp = Convert.ToSingle(textBox1.Text);

            fTemp = cTemp * 1.8f + 32;

            label2.Visible = true;
            label2.Text = Convert.ToString(fTemp);

            label3.Visible = true;
            label3.Text = "F";
        }

        private void FtoC_Click(object sender, EventArgs e)
        {
            float fTemp, cTemp;

            fTemp = Convert.ToSingle(textBox1.Text);

            cTemp = (fTemp - 32) / 9 * 5;

            label2.Visible = true;
            label2.Text = Convert.ToString(cTemp);

            label3.Visible = true;
            label3.Text = "C";
        }
    }
}
