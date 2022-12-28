using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void colculate_Click(object sender, EventArgs e)
        {
            int noodlesQ, sodaQ, total;

            noodlesQ = Convert.ToInt16(noodles.Text);
            sodaQ = Convert.ToInt16(soda.Text);

            total = noodlesQ * 25 + sodaQ * 30;

            output.Text = output.Text + "$" + Convert.ToString(total);
        }
    }
}
