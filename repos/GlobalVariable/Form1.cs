using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalVariable
{
    public partial class Form1 : Form
    {
        int a = 1;
        bool fg = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (fg == false)
            {
                label1.Text = a.ToString();
                a++;
                Refresh();
                if (a > 4)
                {
                    fg = true;
                }
            }
            else if (fg == true)
            {
                label1.Text = a.ToString();
                a--;
                Refresh();
                if (a < 2)
                {
                    fg = false;
                }
            }
        }
    }
}
