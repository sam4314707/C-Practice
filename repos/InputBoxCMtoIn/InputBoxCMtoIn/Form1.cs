using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace InputBoxCMtoIn
{
    public partial class Form1 : Form
    {
        string cm;
        public Form1()
        {
            InitializeComponent();

            cm = Interaction.InputBox("輸入公分", "公分轉英吋", "", -1, -1);


        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            float inch;
            inch = Convert.ToSingle(cm) * 2.54f;
            label1.Text = Convert.ToString(inch) + "英吋";
        }
    }
}
