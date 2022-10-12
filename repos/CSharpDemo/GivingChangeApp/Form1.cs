using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GivingChangeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            double hp, hq, cp, cq, tkm, total, tmp, fhd, hd, ftd, td, fd, od;
            hp = Convert.ToDouble(textBoxHP.Text);
            hq = Convert.ToDouble(textBoxHQ.Text);
            cp = Convert.ToDouble(textBoxCP.Text);
            cq = Convert.ToDouble(textBoxCQ.Text);
            tkm = Convert.ToDouble(textBoxTakeMoney.Text);

            total = hp * hq + cp * cq;
            tmp = tkm - total;
            if(tmp < 0)
            {
                label6.Text = "給的錢不夠!";
                label6.Visible = true;

            }
            else
            {
                fhd = Math.Floor(tmp / 500);
                tmp = tmp % 500;
                hd = Math.Floor(tmp / 100);
                tmp = tmp % 100;
                ftd = Math.Floor(tmp / 50);
                tmp = tmp % 50;
                td = Math.Floor(tmp / 10);
                tmp = tmp % 10;
                fd = Math.Floor(tmp / 5);
                tmp = tmp % 5;
                od = tmp;

                label6.Text = "商品總共： " + total + "元\n" 
                    + "找 500 元" + fhd + "張\n"
                    + "找 100 元" + hd + "張\n"
                    + "找 50 元" + ftd + "枚\n"
                    + "找 10 元" + td + "枚\n"
                    + "找 5 元" + fd + "枚\n"
                    + "找 1 元" + od + "枚";

                label6.Visible = true;
            }
            
        }
    }
}
