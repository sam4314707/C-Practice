using System;
using Animal;
using ConsoleApp1;

namespace CSharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
            // 字串 string "阿翁" 一串文字
            // 字元 char 'a' 一個純文字 x 'aa'
            // 整數 int 40
            // 浮點數 double 40.0
            // 布林值 bool true, false

            string name = "阿翁";
            char sex = 'M';
            int age = 18;
            double height = 15.7;
            bool is_male = true;

            
            Console.WriteLine("我叫" + name); 
            Console.WriteLine("我是" + sex);
            Console.WriteLine("今年" + age + "歲");
            Console.WriteLine("我叫" + name);
            Console.WriteLine("身高是" + height);
            Console.WriteLine("是不是男生" + is_male);

            */

            // 字串常見用法
            /*
            string phrase = "Hello Mr.Dog";
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase.IndexOf("Dog"));
            Console.WriteLine(phrase.Substring(9,2));
            */

            // 數字常見用法 (整數 浮點數)
            /*
            Console.WriteLine(5 * 2);
            Console.WriteLine(5 / 2);
            // int / int return int
            Console.WriteLine(5.0 / 2);
            Console.WriteLine((5 + 2) * 3);

            // 絕對值
            Console.WriteLine(Math.Abs(-19));

            // 次方
            Console.WriteLine(Math.Pow(2,3));

            // 開根號
            Console.WriteLine(Math.Sqrt(36));

            // 最大最小值
            Console.WriteLine(Math.Max(11, 12));
            Console.WriteLine(Math.Min(44, 55));

            // 取整數 四捨六入五成雙
            Console.WriteLine(Math.Round(3.865, 2));
            */

            // 取得用戶輸入
            /*
            Console.Write("請輸入姓名：");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.Write("請輸入年紀：");
            string age = Console.ReadLine();
            Console.WriteLine("你" + age + "歲");
            */

            // 基本計算機

            /*
            Console.Write("請輸入n1：");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("請輸入n2：");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 + num2);
            */

            // Array 陣列
            /*
            int[] scores = { 100, 60, 95, 80, 20 };
            scores[1] = 98;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(scores[i]);
            }

            string[] phones = new string[10];
            phones[0] = "0123456789";
            phones[1] = "08889283834";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(phones[i]);
            }
            */

            // if 判斷句
            /*
            bool hungry = true;
            if (hungry)
            {
                Console.WriteLine("eat");
            }

            bool rainy = false;
            if (rainy)
            {
                Console.WriteLine("drive");
            }
            else
            {
                Console.WriteLine("walk");
            }

            Console.WriteLine("請輸入分數");
            int score = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("是否下雨");
            string rain = Console.ReadLine();
            int money;
            if (score == 100 && rain == "是")
            {
                money = 1000;
            }
            else if(score >= 80 || rain == "是")
            {
                money = 500;
            }
            else if(score >= 60)
            {
                money = 100;
            }
            else
            {
                money = -300;
            }

            Console.WriteLine("我有" + money + "元");

            */

            // 進階計算機

            /*
            double num1 = 0;
            double num2 = 0;
            char c = 'c';
            double ans = 0;

            try
            {
                Console.WriteLine("請輸入num1");
                num1 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("輸入格式錯誤!請輸入數字");
                Console.WriteLine(e.Message);
                return;
            }
            
            
            try
            {
                Console.WriteLine("請輸入num2");
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("輸入格式錯誤!請輸入數字");
                Console.WriteLine(e.Message);
                return;
            }
            
            try
            {
                Console.WriteLine("請輸入運算子");
                c = Convert.ToChar(Console.ReadLine());
                if (c != '+' && c != '-' && c != '*' && c != '/' && c != '%' )
                {
                    Console.WriteLine("輸入格式錯誤!請輸入運算子");
                    return;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("輸入格式錯誤!請輸入運算子");
                Console.WriteLine(e.Message);
                return;
            }


            if (c == '+')
            {
                ans = num1 + num2;
            }else if (c == '-')
            {
                ans = num1 - num2;
            }else if (c == '*')
            {
                ans = num1 * num2;
            }else if (c == '/')
            {
                ans = Math.Round(num1 / num2, 2);
            }else if (c == '%')
            {
                ans = num1 % num2;
            }

            Console.WriteLine("num1" + c + "num2 = " + ans);

            */

            // while 迴圈

            /*
            int i = 0;
            while(i < 5)
            {Instantiate
                Console.WriteLine(i);
                i++;
            }
            */

            // 猜數字
            /*
            
            var rand = new Random();

            
            int ans = rand.Next(101);
            int guess;
            int count = 1;

            Console.WriteLine("猜一個數字(0-100)");
            guess = Convert.ToInt32(Console.ReadLine());


            while (guess != ans)
            {
                if(guess > ans)
                {
                    Console.WriteLine("小一點");
                    guess = Convert.ToInt32(Console.ReadLine());
                }else if(guess < ans)
                {
                    Console.WriteLine("大一點");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                count++;
            }

            Console.WriteLine("恭喜答對! 答案是 " + ans + "\n一共猜了 " + count + " 次");
            */


            // for 迴圈
            /*
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            int[] nums = { 12, 14, 55, 153, 4, 54, 830, 1111 };
            foreach(int i in nums)
            {
                Console.Write("{0} ", i); // {0} 字串插補
            }
            */

            // 2維陣列
            /*
            int[,] nums = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 } };

            int[,] nums2 = new int[3, 3];
            int count = 1;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(nums[i, j]);
                }
            }

            foreach (int i in nums)
            {
                Console.Write("{0} ", i);
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    nums2[i, j] = count;
                    count++;
                }
            }

            foreach (int i in nums2)
            {
                Console.Write("{0} ", i);
            }

            */

            // class object 類別 物件
            /*
            Person person1 = new Person();

            person1.height = 170;
            person1.age = 23;
            person1.name = "Dog";



            Person person2 = new Person();

            person2.height = 180;
            person2.age = 16;
            person2.name = "cat";


            Console.WriteLine(person1.name);
            Console.WriteLine(person2.name);

            person1.SayHi();
            person2.SayHi();

            Console.WriteLine(person1.IsAdult());
            Console.WriteLine(person2.IsAdult());

            Console.WriteLine(person1.Add(50, 20));
            */

            // getter setter
            /*
            Video video1 = new Video("爽喇", "Dog", "大便");
            Video video2 = new Video("讚", "Cat", "教育");

            Console.WriteLine(video1.Type);
            */
            //  static attribute 靜態屬性
            /*
            Video video1 = new Video("爽喇", "Dog", "大便");
            Video video2 = new Video("讚", "Cat", "教育");

            Console.WriteLine(video1.Type);
            Console.WriteLine(video2.Type);
            Console.WriteLine(Video.video_count);
            Console.WriteLine(video1.getVideoCount());

            */


            // static method static class
            /*
            Tool.SayHi();
            */

            // inheritance 繼承

            Student student1 = new Student("Dog", 9, "楊光國小");

            student1.printName();
            student1.printSchool();


        }
    }
}
