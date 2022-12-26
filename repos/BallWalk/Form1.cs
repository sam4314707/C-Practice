using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallWalk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void ovalShape1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                ovalShape1.Left -= 10;
                Refresh();
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}
