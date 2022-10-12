using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Hello = "Hello, C#";
            string RedWater = "RedWater";
            string BlueWater = "BlueWater";
            int Percentage = 100;


            MessageBox.Show(Hello + Environment.NewLine + RedWater + ":" + Percentage + "%"
                + Environment.NewLine + BlueWater + ":" + Percentage);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cal = 6 + 3 * 8 / (7 - 3);
            MessageBox.Show(cal.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ValueInt = 2;
            int routeTips;

            if (ValueInt > 1)
            {
                MessageBox.Show("左轉", "第一關");
                routeTips = 2;
            }
            else if (ValueInt < 1)
            {
                MessageBox.Show("右轉", "第一關");
                routeTips = 1;
            }
            else
            {
                MessageBox.Show("此路不通", "第一關");
                routeTips = 3;
            }

            switch (routeTips)
            {
                case 1:
                    MessageBox.Show("掉到洞裡", "第二關");
                    break;
                case 2:
                    MessageBox.Show("Good", "第二關");
                    break;
                default:
                    MessageBox.Show("爛bo", "第二關");
                    break;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //將呈現的紀錄文字
            string ShowString = "";

            //虺五百年化為蛟，已經過了150年，因此狀態改變需要350年
            int UpdateStatus = 350;

            int start = 1; //初始化
            int end = start + 150; //時光150年，需加上初始值

            //迴圈turbo全速運轉，Go
            while (start < end)
            {
                if (start % 10 == 0)
                {
                    ShowString += "已過" + start + "個年頭 => 等級提升，尚需" + (UpdateStatus - start) + "年" + Environment.NewLine;
                }

                start++; //每執行一次+1
            }

            MessageBox.Show("時光流速turbo全速運轉結果：" + Environment.NewLine + ShowString);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 將呈現的紀錄文字
            string ShowString = "";

            // 虺五百年化為蛟，因此狀態改變需要500年
            int UpdateStatus = 500;

            // 迴圈turbo全速運轉，GO!
            for (int i = 1; i < 101; i++)
            {
                if (i % 10 == 0)
                {
                    ShowString += "已過" + i + "個年頭 => 等級提升，尚需"
                        + (UpdateStatus - i) + "年" + Environment.NewLine;
                }
            }

            MessageBox.Show("時光流速turbo全速運轉結果：" + Environment.NewLine
                + ShowString);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 將呈現的紀錄文字
            string ShowString = "";

            // 虺五百年化為蛟，已過了100年，因此狀態改變需要400年
            int UpdateStatus = 400;
            int start = 1; // initialize
            int end = start + 50; // 時光50年，須加上初始值

            // 迴圈turbo全速運轉，GO!
            do
            {
                if (start % 10 == 0)
                {
                    ShowString += "已過" + "個年頭 => 等級提升，尚需"
                        + (UpdateStatus - start) + "年" + Environment.NewLine;
                }

                start++; // 每執行一次+1

            } while (start < end);

            MessageBox.Show("時光流速turbo全速運轉結果：" + Environment.NewLine
                + ShowString);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //將呈現的紀錄文字
            string ShowString = "";

            //虺五百年化為蛟，已經過了150年，因此狀態改變需要200年
            int UpdateStatus = 200;

            int[] ValueArray = new int[] { 125, 75 };
            foreach (int element in ValueArray)
            {
                ShowString += "已過" + element + "個年頭 => 等級提升，尚需" + (UpdateStatus - element) + "年" + Environment.NewLine;
                UpdateStatus = UpdateStatus - element;
            }

            MessageBox.Show("時光流速turbo全速運轉結果：" + Environment.NewLine + ShowString + "「虺」已進化成「蛟」");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BraveActionList.Back();
        }

        private BraveActionClass BraveActionList = new BraveActionClass();

        private void button9_Click(object sender, EventArgs e)
        {
            BraveActionList.LotteryMember();
        }
    }

    public class BraveActionClass
    {
        public void Back()
        {
            MessageBox.Show("正在前往村子...");

        }

        public void LotteryMember()
        {
            string member = "";

            // 實體化Random物件
            Random random = new Random();
            int returnInt = random.Next(1, 6);

            switch (returnInt)
            {
                case 1:
                    member = "子丑";
                    break;
                case 2:
                    member = "寅卯";
                    break;
                case 3:
                    member = "辰巳";
                    break;
                case 4:
                    member = "午未";
                    break;
                case 5:
                    member = "申酉";
                    break;
                case 6:
                    member = "戌亥";
                    break;
            }

            MessageBox.Show(member, "招攬夥伴");

        }
    }
}
