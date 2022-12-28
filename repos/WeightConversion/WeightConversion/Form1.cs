using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeightConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float kg, lb;

            kg = Convert.ToSingle(textBox1.Text);

            lb = kg * 2.2046f; //浮點數要加f

            label2.Visible = true;
            label2.Text = Convert.ToString(lb);

            label3.Visible = true;
        }
    }
}
