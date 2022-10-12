using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncingBall
{
    public partial class Form1 : Form
    {
        int LRmove = 10; // 球每次的移動量
        int UDmove = 10;
        int tmpl, tmpu;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ovalShape1.Left + LRmove <= 0 || ovalShape1.Left + ovalShape1.Width + LRmove >= ClientSize.Width)
                LRmove = -LRmove;

            ovalShape1.Left += LRmove;

            if (ovalShape1.Top + UDmove <= 0 || ovalShape1.Top + ovalShape1.Height + UDmove >= ClientSize.Height)
                UDmove = -UDmove;

            ovalShape1.Top += UDmove;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(LRmove != 0)
                {
                    tmpl = LRmove;
                    tmpu = UDmove;
                    LRmove = 0;
                    UDmove = 0;
                }
                else
                {
                    LRmove = tmpl;
                    UDmove = tmpu;
                }
                
            }
        }
    }
}
