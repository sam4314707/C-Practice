using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringBuilderClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder str1;


            str1 = new StringBuilder(5);

            textBox1.Clear();

            str1.Append("1234");
            textBox1.AppendText("Capacity = " + str1.Capacity.ToString() + "\r\n");

            str1.Append("5678"); // 附加"5678" 會超過原來的容量
            textBox1.AppendText("str1 = " + str1.ToString() + "\r\n");
            textBox1.AppendText("Capacity = " + str1.Capacity.ToString() + "\r\n");
            textBox1.AppendText("Length = " + str1.Length.ToString() + "\r\n");

            str1.Length = 15;
            textBox1.AppendText("Capacity = " + str1.Capacity.ToString() + "\r\n");
            textBox1.AppendText("Length = " + str1.Length.ToString() + "\r\n");
            textBox1.AppendText("str1 = " + str1.ToString() + "\r\n");

            // 清除字串內容，再重新給值
            str1.Clear();
            str1.Append("123");
            textBox1.AppendText("str1 = " + str1.ToString() + "\r\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder str1;

            // 分配空字串，預設容量為16
            str1 = new StringBuilder();

            textBox1.Clear();

            textBox1.AppendText(str1.Capacity.ToString() + "\r\n");

            str1.Append("12345678901234567");
            str1.Length = 10; // str1.Capacity = 10 會錯誤
            textBox1.AppendText(str1.Capacity.ToString() + "\r\n");
            textBox1.AppendText(str1.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder str1 = new StringBuilder("123");
            StringBuilder str2 = new StringBuilder();
            char[] c = { 'a', 'b', 'c', 'd', 'e' };
            char[] c1 = new char[4];

            textBox1.Clear();
            // Append範例
            textBox1.AppendText(str1.Length.ToString() + "\r\n");
            str1.AppendLine();
            textBox1.AppendText(str1.Length.ToString() + "\r\n");

            // str1會因為AppendLine的關係，會被切成兩行
            str1.Append('c', 5).AppendLine("11111");
            textBox1.AppendText(str1.ToString());

            str2.AppendFormat("我和{0}一同去買了{1}本筆記本", "小明", 3);
            textBox1.AppendText(str2.ToString() + "\r\n");

            str2.CopyTo(1, c1, 0, 4);
            textBox1.AppendText(new string(c1) + "\r\n");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder str1 = new StringBuilder("abcd");
            StringBuilder str2 = new StringBuilder("1234567");

            textBox1.Clear();
            // Equals
            textBox1.AppendText(str1.Equals("abcd").ToString() + "\r\n");

            // Insert
            str2.Insert(3, "abc", 2);
            textBox1.AppendText(str2.AppendLine().ToString());

            str2.Remove(3, 6);
            textBox1.AppendText(str2.ToString());

            str2.Clear();
            str2.Append("123abc456abc789abc");
            str2.Replace("abc", "QAQ", 3, 9);
            textBox1.AppendText(str2.ToString());
        }
    }
}
