using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EletricityBillApp
{
    public partial class Form1 : Form
    {
        double kWh, EB, kWh56, kWh67, kWho7;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kWh = Convert.ToDouble(textBox1.Text);

            if (kWh <= 500)
            {
                EB = kWh * 2.56;
            }
            else if (kWh > 500 && kWh <= 600)
            {
                kWh56 = kWh - 500;
                EB = 500 * 2.56 + kWh56 * 3.2;
            }
            else if (kWh > 600 && kWh <= 700)
            {
                kWh56 = 100;
                kWh67 = kWh - 600;
                EB = 500 * 2.56 + kWh56 * 3.2 + kWh67 * 4.5;
            }
            else if (kWh > 700)
            {
                kWh56 = 100;
                kWh67 = 100;
                kWho7 = kWh - 700;
                EB = 500 * 2.56 + kWh56 * 3.2 + kWh67 * 4.5 + kWho7 * 5.5;
            }

            MessageBox.Show(Convert.ToString(EB), "電費");

        }
    }
}
