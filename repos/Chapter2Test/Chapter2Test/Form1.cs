using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter2Test
{
    public partial class Form1 : Form
    {
        double Ch, En, Ma;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ch = Convert.ToDouble(textBox1.Text);
            En = Convert.ToDouble(textBox2.Text);
            Ma = Convert.ToDouble(textBox3.Text);

            if ((Ch + En + Ma) / 3 >= 85 && Ch >= 80 && En >= 80 && Ma >= 80)
            {
                MessageBox.Show("資格符合，可申請獎學金");
            }
            else
            {
                MessageBox.Show("資格不符");
            }
        }
    }
}
