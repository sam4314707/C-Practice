using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringBuilderFormat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder str1;
            str1 = new StringBuilder();

            str1.AppendFormat("王曉明買了{0}{1}個，一個單價{2}元，一共是{3}元。", textBox1.Text, textBox3.Text, textBox2.Text,
                (Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox3.Text)).ToString());
            label4.Text = str1.ToString() ;
        }
    }
}
