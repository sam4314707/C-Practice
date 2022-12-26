using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooTicketApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int NormalTK = 0, stuTK = 0, ISICTK = 0, kidF = 0, DisableF = 0, ElderF = 0, numofP;
            double total;
            if(textBox1.Text != "")
            {
                NormalTK = Convert.ToInt32(textBox1.Text);
            }
            if (textBox2.Text != "")
            {
                stuTK = Convert.ToInt32(textBox2.Text);
            }
            if (textBox3.Text != "")
            {
                ISICTK = Convert.ToInt32(textBox3.Text);
            }
            if (textBox4.Text != "")
            {
                kidF = Convert.ToInt32(textBox4.Text);
            }
            if (textBox5.Text != "")
            {
                DisableF = Convert.ToInt32(textBox5.Text);
            }
            if (textBox6.Text != "")
            {
                ElderF = Convert.ToInt32(textBox6.Text);
            }

            numofP = NormalTK + stuTK + ISICTK + kidF + DisableF + ElderF;

            if(numofP < 30)
            {
                total = NormalTK * 60 + stuTK * 30 + ISICTK * 30;
                label8.Text = Convert.ToString(total);
            }
            else
            {
                total = (NormalTK * 60 + stuTK * 30 + ISICTK * 30) * 0.7;
                label8.Text = "團體票價打七折  " + Convert.ToString(total);
            }

            
        }
    }
}
