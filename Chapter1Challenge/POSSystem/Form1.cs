using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSSystem
{
    public partial class Form1 : Form
    {
        int insP, insQ, sodaP, sodaQ, total, pay, changeTotal;
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckoutBtn_Click(object sender, EventArgs e)
        {
            insP = Convert.ToInt32(textBoxInsPrice.Text);
            insQ = Convert.ToInt32(textBoxInsQuan.Text);
            sodaP = Convert.ToInt32(textBoxSodaPrice.Text);
            sodaQ = Convert.ToInt32(textBoxSodaQuan.Text);

            total = insP * insQ + sodaP * sodaQ;
            pay = Convert.ToInt32(textBoxPay.Text);

            if (total == 0)
            {
                labelChange.Text = "Total price must more than 0 !!";
                return;
            }

            if (pay < total)
            {
                labelChange.Text = "Need more money!!";
                return;
            }

            changeTotal = pay - total;

            int changeFH = changeTotal / 500;
            changeTotal -= changeFH * 500;
            int changeH = changeTotal / 100;
            changeTotal -= changeH * 100;
            int changeFT = changeTotal / 50;
            changeTotal -= changeFT * 50;
            int changeT = changeTotal / 10;
            changeTotal -= changeT * 10;
            int changeO = changeTotal;

            labelTotal.Text = "Total : $" + Convert.ToString(total);
            labelChange.Text = "Change : $500 * " + Convert.ToString(changeFH) 
                + "\n$100 * " + Convert.ToString(changeH)
                + "\n$50 * " + Convert.ToString(changeFT) 
                + "\n$10 * " + Convert.ToString(changeT)
                + "\n$1 * " + Convert.ToString(changeO);
        }
    }
}
