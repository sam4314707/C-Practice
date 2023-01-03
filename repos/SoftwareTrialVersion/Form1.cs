using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTrialVersion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] endDt = textBox1.Text.Split(',');
            int v;

            DateTime dt = new DateTime(Convert.ToInt32(endDt[0]), Convert.ToInt32(endDt[1]), Convert.ToInt32(endDt[2]));
            DateTime dt1 = DateTime.Now;
            dt1 = dt1.AddDays(30);

            v = dt.CompareTo(dt1);

            if (v == 1)
            {
                MessageBox.Show("Trial Version was shutdown.");
            }
            else
            {
                MessageBox.Show("Trial Version Operating.");
            }

        }
    }
}
