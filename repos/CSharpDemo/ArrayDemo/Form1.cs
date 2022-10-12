using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ArrayDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 箱子
        Dictionary<string, string> BoxArray = new Dictionary<string, string>();
        int count = 10; // 顯示容量用
        


        private void button1_Click(object sender, EventArgs e)
        {
            string SaveKey = Interaction.InputBox("存入物品鍵值", "存入鍵值", "", -1, -1);
            // -1表示在螢幕中間
            string SaveName = Interaction.InputBox("存入物品名稱", "存入", "", -1, -1);
            // -1表示在螢幕中間

            // 驗證是否為空 
            if (!String.IsNullOrEmpty(SaveName))
            {
                BoxArray.Add(SaveKey, SaveName);
                count--;
                label4.Text = count.ToString();

            }
            else if (count <= 0)
            {
                MessageBox.Show("可儲存的容量不足", "Error Message");
            }

            // 重新取得清單
            ArrayData();
        }

        // 判斷書入值是否為數字
        private bool IsNumber(string TextBoxValue)
        {
            try
            {
                int i = Convert.ToInt32(TextBoxValue);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // 取得目前盒子內儲存清單
        private void ArrayData()
        {
            string tmpString = "";
            foreach(KeyValuePair<string, string> GetBoxArray in BoxArray)
            {
                tmpString += "第" + GetBoxArray.Key + "空間位置 => "
                    + GetBoxArray.Value + Environment.NewLine;
            }

            label5.Text = tmpString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = count.ToString(); // 目前容量
            label4.Text = count.ToString(); // 容量還剩
            ArrayData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string GetString = Interaction.InputBox("取出物品鍵值", "取出鍵值", "", -1, -1);


            // 驗證是否有找到值，如錯誤則跳出錯誤訊息
            try
            {
                MessageBox.Show("取出物品：" + BoxArray[GetString]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "錯誤訊息");
            }




        }
    
    
    
    }



}
