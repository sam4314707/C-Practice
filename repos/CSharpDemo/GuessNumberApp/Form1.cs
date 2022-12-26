using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumberApp
{
    public partial class Form1 : Form
    {
        int myAns, comAns, myGuess, comGuess, gameNum, myW, comW;

        public Form1()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            myGuess = Convert.ToInt32(textBox2.Text);
            comGuess = rand.Next(1, 4);

            if (myGuess == comAns && comGuess == myGuess)
            {
                textBox3.AppendText("平手\r\n");
                myW++;
                comW++;
                if (gameNum < 3)
                {
                    textBox3.AppendText("輸入下回合數字\r\n");
                    button1.Visible = true;
                }
                else
                {
                    endGame();
                }
            }
            else if (myGuess == comAns)
            {
                textBox3.AppendText("玩家得分\r\n");
                myW++;
                if (gameNum < 3)
                {
                    textBox3.AppendText("輸入下回合數字\r\n");
                    button1.Visible = true;
                }
                else
                {
                    endGame();
                }
            }
            else if (comGuess == myAns)
            {
                textBox3.AppendText("電腦得分\r\n");
                comW++;
                if (gameNum < 3)
                {
                    textBox3.AppendText("輸入下回合數字\r\n");
                    button1.Visible = true;
                }
                else
                {
                    endGame();
                }
            }
            else
            {
                textBox3.AppendText("雙方都沒猜到\r\n");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            myAns = Convert.ToInt32(textBox1.Text);
            if (myAns < 1 && myAns > 4)
            {
                textBox3.AppendText("謎底必須為數字1-4\r\n");

            }
            else
            {
                gameNum++;
                comAns = rand.Next(1, 4);
                textBox3.AppendText("輸入成功，電腦也輸入亂數1-4成功\r\n");
                textBox3.AppendText("回合" + gameNum + "\r\n");
                button1.Visible = false;
            }
        }

        public void endGame()
        {
            textBox3.AppendText("玩家得分： " + myW + "   電腦得分： " + comW + "\r\n");
            if (myW > comW)
            {
                textBox3.AppendText("玩家獲勝\r\n");
            }
            else if (comW > myW)
            {
                textBox3.AppendText("電腦獲勝\r\n");
            }
            else
            {
                textBox3.AppendText("雙方得分相同\r\n");
            }

            gameNum = 0;
            myW = 0;
            comW = 0;
            button1.Visible = true;
        }
    }
}
