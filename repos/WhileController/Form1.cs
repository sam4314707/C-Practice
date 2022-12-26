using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhileController
{
    public partial class Form1 : Form
    {
        bool fg;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;

            fg = true;

            while (fg == true)
            {
                i++;
                label1.Text = i.ToString();
                if(i == 10000)
                {
                    i = 0;
                }

                Application.DoEvents(); // 讓表單能夠收到訊息
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fg = false;
        }
    }
}
