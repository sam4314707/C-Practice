using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Person
    {
        public double height;
        public int age;
        public string name;

        public Person()
        {
            Console.WriteLine("創建成功!");
        }

        public void SayHi()
        {
            Console.WriteLine("我是" + name);
        }

        public bool IsAdult()
        {
            if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Add(int num1, int num2)
        {
            return num1 + num2;

        }

        public void printName()
        {
            Console.WriteLine(name);

        }

        public void printAge()
        {
            Console.WriteLine(age);

        }
    }
    
    class Student : Person
    {
        public string school;
        public Student(string name, int age, string school)
        {
            this.name = name;
            this.age = age;
            this.school = school;
        }

        public void printSchool()
        {
            Console.WriteLine(school);
        }
    }
}

namespace ConsoleApp1
{
    class Video
    {
        public string title;
        public string author;
        // 影片類型只有四種：教育、娛樂、音樂、其他
        private string type;
        public static int video_count = 0;

        public Video(string title, string author, string type)
        {
            this.title = title;
            this.author = author;
            Type = type;
            video_count++;
        }

        public string Type
        {
            get { return type; }
            set
            {
                if (value == "教育" || value == "娛樂" || value == "音樂" || value == "其他")
                {
                    type = value;
                }
                else
                {
                    type = "其他";
                }

            }
        }

        public int getVideoCount()
        {
            return video_count;
        }



    }

    static class Tool
    {
        public static void SayHi()
        {
            Console.WriteLine("Hello你好嗎?");
        }
    }
}

