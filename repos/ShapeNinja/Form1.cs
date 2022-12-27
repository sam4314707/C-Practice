using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeNinja
{

    public partial class Form1 : Form
    {
        Random rd, rd2, rd3;
        int Score;

        private void timer2_Tick(object sender, EventArgs e)
        {
            ovalShape2.Left = rd.Next(0 + ovalShape2.Width, this.Width - ovalShape2.Width);
            ovalShape2.Top = rd.Next(0 + ovalShape2.Height, this.Height - ovalShape2.Height);
            timer2.Interval = rd.Next(1000, 3000);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            rectangleShape1.Left = rd.Next(0 + rectangleShape1.Width, this.Width - rectangleShape1.Width);
            rectangleShape1.Top = rd.Next(0 + rectangleShape1.Height, this.Height - rectangleShape1.Height);
            timer3.Interval = rd.Next(1000, 3000);
        }

        private void ovalShape1_Click(object sender, EventArgs e)
        {
            ovalShape1.Left = rd.Next(0 + ovalShape1.Width, this.Width - ovalShape1.Width);
            ovalShape1.Top = rd.Next(0 + ovalShape1.Height, this.Height - ovalShape1.Height);
            timer1.Interval = rd.Next(1000, 3000);
            Score += 5;
            label1.Text = Score.ToString();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {
            rectangleShape1.Left = rd.Next(0 + rectangleShape1.Width, this.Width - rectangleShape1.Width);
            rectangleShape1.Top = rd.Next(0 + rectangleShape1.Height, this.Height - rectangleShape1.Height);
            timer3.Interval = rd.Next(1000, 3000);
            Score += 5;
            label1.Text = Score.ToString();

        }

        private void ovalShape2_Click(object sender, EventArgs e)
        {
            ovalShape2.Left = rd.Next(0 + ovalShape2.Width, this.Width - ovalShape2.Width);
            ovalShape2.Top = rd.Next(0 + ovalShape2.Height, this.Height - ovalShape2.Height);
            timer2.Interval = rd.Next(1000, 3000);
            Score -= 10;
            label1.Text = Score.ToString();
        }

        public Form1()
        {
            InitializeComponent();
            rd = new Random();
            System.Threading.Thread.Sleep(100);
            rd2 = new Random();
            System.Threading.Thread.Sleep(100);
            rd3 = new Random();
            System.Threading.Thread.Sleep(100);
            Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ovalShape1.Left = rd.Next(0 + ovalShape1.Width, this.Width - ovalShape1.Width);
            ovalShape1.Top = rd.Next(0 + ovalShape1.Height, this.Height - ovalShape1.Height);
            timer1.Interval = rd.Next(1000, 3000);

        }
    }
}
