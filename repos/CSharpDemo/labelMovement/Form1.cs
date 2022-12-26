using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labelMovement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case (Keys)37:
                    label1.Left -= 10;
                    break;
                case (Keys)39:
                    label1.Left += 10;
                    break;
                case (Keys)38:
                    label1.Top -= 10;
                    break;
                case (Keys)40:
                    label1.Top += 10;
                    break;
            }
        }
    }
}
