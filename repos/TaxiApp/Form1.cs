using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiApp
{
    public partial class Form1 : Form
    {
        double totalKM, wasteTime, Fare;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            totalKM = Convert.ToDouble(textBox1.Text);
            wasteTime = Convert.ToDouble(textBox2.Text);
            Fare = 0;

            if (totalKM > 1.25)
            {
                Fare = 70 + (totalKM - 1.25) / 0.2 * 5;
            }
            else
            {
                Fare += 70;
            }

            if (wasteTime > 0)
            {
                Fare += wasteTime / 80 * 5;
            }

            if (radioButton1.Checked)
            {
                Fare += 20;
            }
            if (radioButton2.Checked)
            {
                Fare += 20;
            }

            label5.Text = "總金額： " + Fare + " 元 ";
        }
    }
}
