using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeasonApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int month;
            month = Convert.ToInt32(comboBox1.Text);
            switch (month)
            {
                case 3:
                case 4:
                case 5:
                    label3.Text = "春";
                    break;
                case 6:
                case 7:
                case 8:
                    label3.Text = "夏";
                    break;
                case 9:
                case 10:
                case 11:
                    label3.Text = "秋";
                    break;
                case 12:
                case 1:
                case 2:
                    label3.Text = "冬";
                    break;
            }
        }
    }
}
