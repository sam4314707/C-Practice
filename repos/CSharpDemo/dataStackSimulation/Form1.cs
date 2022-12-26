using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataStackSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string option;

            option = textBox1.Text;

            switch (option)
            {
                case "1":
                    MessageBox.Show("新增資料完成");
                    break;
                case "2":
                    MessageBox.Show("刪除資料完成");
                    break;
                case "3":
                    MessageBox.Show("修改資料完成");
                    break;
                case "4":
                    DialogResult result = MessageBox.Show("確定要結束?", "結束", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        System.Environment.Exit(0);
                    }
                    break;
                default:
                    MessageBox.Show("輸入錯誤");
                    break;

            }
        }
    }
}
