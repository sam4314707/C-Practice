using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GoBtn_Click(object sender, EventArgs e)
        {
            string title, Msg;
            DialogResult result;

            title = TitleTextBox.Text;
            Msg = MsgTextBox.Text;

            result = MessageBox.Show(Msg, title, MessageBoxButtons.YesNo, 
                MessageBoxIcon.Exclamation, 
                MessageBoxDefaultButton.Button1);

            output.Text = result.ToString();
            output.Visible = true;


        }
    }
}
