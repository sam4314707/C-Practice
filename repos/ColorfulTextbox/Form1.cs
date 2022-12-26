using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorfulTextbox
{
    public partial class Form1 : Form
    {
        string key;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            key = textBox1.Text;
            if (key == "1")
            {
                textBox2.BackColor = Color.Red;
            }
            else if (key == "2")
            {
                textBox2.BackColor = Color.Green;
            }
            else if (key == "3")
            {
                textBox2.BackColor = Color.Yellow;
            }
        }
    }
}
