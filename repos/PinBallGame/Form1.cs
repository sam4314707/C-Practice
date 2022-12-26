using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinBallGame
{
    public partial class Form1 : Form
    {
        int LRmove = 10; // 球每次的移動量
        int UDmove = 10;
        int Point = 0;
        // int tmpl, tmpu;
        public Form1()
        {
            InitializeComponent();
        }

        bool mDown = false;


        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mDown)
            {
                var pos = this.PointToClient(Cursor.Position);
                label1.Location = new Point(pos.X - 45, label1.Location.Y);
            }

        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            mDown = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ovalShape1.Left + LRmove <= 0 || ovalShape1.Left + ovalShape1.Width + LRmove >= ClientSize.Width)
                LRmove = -LRmove;



            if (ovalShape1.Top + UDmove <= 0)
                UDmove = -UDmove;

            if(ovalShape1.Top + ovalShape1.Height + UDmove >= ClientSize.Height)
            {
                UDmove = -UDmove;
                if(Point > 0)
                {
                    Point--;
                    label3.Text = Convert.ToString(Point);
                }
                
            }

            collision();



            ovalShape1.Left += LRmove;
            ovalShape1.Top += UDmove;


        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            mDown = false;
        }

        public void collision()
        {
            if (ovalShape1.Top + ovalShape1.Height >= label1.Top
                && ovalShape1.Top + ovalShape1.Height <= label1.Top + label1.Height
                && ovalShape1.Left + ovalShape1.Width >= label1.Left
                && ovalShape1.Left + ovalShape1.Width <= label1.Left + label1.Width)
            {
                UDmove = -UDmove;
                Point++;
                label3.Text = Convert.ToString(Point);
                
            }
        }
    }
}
