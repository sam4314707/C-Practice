using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControllerEventPractice
{
    public partial class Form1 : Form
    {
        int width;
        int height;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 37)
            {
                label1.Left -= 10;
            }

            if(e.KeyValue == 38)
            {
                label1.Top -= 10;
            }

            if(e.KeyValue == 39)
            {
                label1.Left += 10;
            }

            if(e.KeyValue == 40)
            {
                label1.Top += 10;
            }
        }

        

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            width = this.Width;
            height = this.Height;
            label1.Text ="寬度：" + Convert.ToString(width) + " " + "長度：" + Convert.ToString(height);
        }
    }
}
