using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtoZPrinter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 26; i++)
            {
                int unicode = i + 64;
                char character = (char)unicode;
                string text = character.ToString();
                textBox1.AppendText(text);
                textBox1.AppendText(Environment.NewLine);
            }
        }
    }
}
