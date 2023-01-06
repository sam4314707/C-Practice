using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = "abcdefghijk";
            string str2 = "accdefghijk";
            const string str3 = "你好嗎？";
            string str4 = "\0\0";
            string str5;
            int v;
            bool fg;
            string[] str6; // 字串陣列

            textBox1.AppendText(str1.Length.ToString() + "\r\n");
            textBox1.AppendText(str3.Length.ToString() + "\r\n");
            textBox1.AppendText(str4.Length.ToString() + "\r\n");

            // 取出某個字元
            textBox1.AppendText(str1[3].ToString() + "\r\n");
            v = String.Compare(str1, str2); // 字串裡的字元順序比較
            textBox1.AppendText(v.ToString() + "\r\n");

            str5 = String.Concat("王曉明," + str3);
            textBox1.AppendText(str5 + "\r\n");

            fg = str1.Contains("cde");
            textBox1.AppendText(fg.ToString() + "\r\n");

            str5 = str3.PadRight(10, 'c');
            textBox1.AppendText(str5 + "\r\n");

            // 刪除：從位置2開始，刪除4個字元
            str5 = str1.Remove(2, 4);
            textBox1.AppendText(str5 + "\r\n");

            // 取代：用'6'取代's'
            str1 = "This is a book.";
            str5 = str1.Replace('s', '6');
            textBox1.AppendText(str5 + "\r\n");

            str5 = "This is a book";
            str6 = str5.Split(' '); // 取出str6字串陣列裡的每一個元素
            foreach (var s in str6)
            {
                textBox1.AppendText(s + "\r\n");
            }

            // 移除頭尾空白
            str5 = "    This is a book.     ".Trim();
            textBox1.AppendText(str5 + "\r\n");

            // 自我練習
            string str7 = "i1a#mDa5sCtdu^d>egndt2";
            for (int i = 0; i < str7.Length; i += 2)
            {
                textBox1.AppendText(str7[i].ToString());
            }
        }
    }
}
