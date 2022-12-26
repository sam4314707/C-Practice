using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasherOnSaleApp
{
    public partial class Form1 : Form
    {
        double buy, total;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buy = Convert.ToDouble(textBox1.Text);
            if(buy > 5000)
            {
                total = (buy - 5000) * 0.9 + 5000;
            }
            else
            {
                total = buy;
            }

            MessageBox.Show(Convert.ToString(total), "折扣後金額");
        }
    }
}
