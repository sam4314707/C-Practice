using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothesCasher
{
    public partial class Form1 : Form
    {
        double Quantity, Total;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Quantity = Convert.ToDouble(textBox1.Text);
            if (Quantity < 5)
            {
                Total = 230 * Quantity;
                MessageBox.Show(Convert.ToString(Total), "價錢");
            }
            else if (Quantity >= 5 && Quantity < 11)
            {
                Total = 230 * Quantity * 0.9;
                MessageBox.Show(Convert.ToString(Total), "價錢");
            }
            else
            {
                Total = 230 * Quantity * 0.8;
                MessageBox.Show(Convert.ToString(Total), "價錢");
            }
        }
    }
}
