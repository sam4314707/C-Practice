using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalkAnimation
{
    public partial class Form1 : Form
    {
        bool fg;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fg = true;
            int x = 10;
            int move = 10;
            int index = 0;


            pictureBox1.Left = x; //設定初始的pictuteBox1的位置
            // 將imageList1的影像的寬與高設定給pictureBox1
            pictureBox1.Width = imageList1.ImageSize.Width;
            pictureBox1.Height = imageList1.ImageSize.Height;

            while (x + pictureBox1.Width + move < ClientSize.Width && fg == true)
            {
                pictureBox1.Image = imageList1.Images[index];
                x += move;
                pictureBox1.Left = x;

                if (++index > 4)
                    index = 0;
                Refresh();
                System.Threading.Thread.Sleep(100);

                Application.DoEvents();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fg = false;
        }
    }
}
