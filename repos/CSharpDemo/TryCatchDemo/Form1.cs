using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryCatchDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*double n1, n2, n3;
            try
            {
                n1 = Convert.ToDouble(textBox1.Text);
                textBox3.Text += "n1 = " + Convert.ToString(n1);
                n2 = Convert.ToDouble(textBox2.Text);
                textBox3.Text += "\r\nn2 = " + Convert.ToString(n2);
                n3 = n1 / n2;
                textBox3.Text += "\r\nAns: " + Convert.ToString(n3);
                label3.Text = Convert.ToString(n3);
            }catch(Exception ex)
            {
                textBox3.Text += ex.Message;
            }*/
            decimal a = 1, b = 1, c;
            bool fgError;

            try
            {
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
                fgError =  false;
            }
            catch(FormatException ex)
            {
                textBox3.AppendText(ex.Message + "\r\n");
                a = 1;
                b = 1;
                fgError = true;
            }
            finally
            {
                textBox3.AppendText("a=" + a.ToString() + "\r\n");
                textBox3.AppendText("b=" + b.ToString() + "\r\n");
            }

            if (fgError == false)
                try
                {
                    c = a / b;
                    label3.Text = c.ToString();
                }
                catch (DivideByZeroException ex)
                {
                    textBox3.AppendText(ex.Message + "\r\n");
                    label3.Text = "";
                    b = 1;
                    textBox2.Text = b.ToString();
                }
        }
    }
}
