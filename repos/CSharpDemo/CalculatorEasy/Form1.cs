using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorEasy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string mathematical;
        string beforeValue;
        private void buttonNumber_Click(object sender, EventArgs e)
        {
            Button buttonNumber = sender as Button;
             if (textBox1.Text == "0")
            {
                textBox1.Text = buttonNumber.Text;

            }
            else
            {
                textBox1.Text += buttonNumber.Text;
            }
        }

        private void buttonMathematical_Click(object sender, EventArgs e)
        {
            Button buttonMathematical = sender as Button;
            mathematical = buttonMathematical.Text; // 記錄所點擊的運算式
            beforeValue = textBox1.Text; // 記錄使用者輸入前一個值的內容
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {

            Double GetBeforeValue = Double.Parse(beforeValue);
            Double GetAfterValue = Double.Parse(textBox1.Text);
            Double Result = 0;

            switch (mathematical)
            {
                case "+":
                    Result = GetBeforeValue + GetAfterValue;
                    break;
                case "-":
                    Result = GetBeforeValue - GetAfterValue;
                    break;
                case "*":
                    Result = GetBeforeValue * GetAfterValue;
                    break;
                case "/":
                    Result = GetBeforeValue / GetAfterValue;
                    break;




            }

            textBox1.Text = Result.ToString();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
