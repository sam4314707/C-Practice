using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using System.Collections;

namespace CalculatorDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfixToPostfix.Implementation imp = new InfixToPostfix.Implementation();
            string input = textBoxFormula.Text;
            string result = imp.Infix_To_Postfix(ref input);
            Console.WriteLine(result);

            double ans = PostfixCal.Calculate.Cal(result);
            labelAns.Visible = true;
            labelAns.Text = "Postfix: " + result + "  Anser: " + ans;


        }
    }


}

namespace InfixToPostfix
{
    public class Implementation
    {
        public int precedence(char op)
        {
            if (op == '*' || op == '/' || op == '%')
                return 3;
            else if (op == '+' || op == '-')
                return 2;
            else if (op == '^')
                return 1;
            else return -1;
        }

        public string Infix_To_Postfix(ref string expn)
        {
            Stack<char> stk = new Stack<char>();
            string output = "";
            char _out;
            foreach (var ch in expn)
            {
                bool isAlphaBet = Regex.IsMatch(ch.ToString(), "[a-z]", RegexOptions.IgnoreCase);

                if (Char.IsDigit(ch) || isAlphaBet)
                {
                    output = output + ch;
                }
                else
                {
                    switch (ch)
                    {
                        case '+':
                        case '-':
                        case '*':
                        case '/':
                        case '%':
                        case '^':
                            while (stk.Count > 0 && precedence(ch) <= precedence(stk.Peek()))
                            {
                                _out = stk.Peek();
                                stk.Pop();
                                output = output + " " + _out;
                            }
                            stk.Push(ch);
                            output = output + " ";
                            break;
                        case '(':
                            stk.Push(ch);
                            break;
                        case ')':
                            while (stk.Count > 0 && (_out = stk.Peek()) != '(')
                            {
                                stk.Pop();
                                output = output + " " + _out + " ";
                            }
                            if (stk.Count > 0 && (_out = stk.Peek()) == '(')
                                stk.Pop();
                            break;
                    }
                }
            }
            while (stk.Count > 0)
            {
                _out = stk.Peek();
                stk.Pop();
                output = output + " " + _out;
            }
            return output;
        }

    }
}

namespace PostfixCal
{
    public static class Calculate
    {
        
        public static double Cal(string postfix)
        {
            Stack<string> myStack = new Stack<string>();
            object temp1 = "";
            object temp2 = "";
            double ans = 0;
            int count = 0;

            for (int i = 0; i < postfix.Length;)
            {
                count = 0;
                for (int j = i; j < postfix.Length; j++)
                {
                    string cs = postfix.Substring(j, 1);
                    if (cs == " ") 
                    {
                        break;
                    }
                    count++;
                }
                string s = postfix.Substring(i, count);
                if (s == "+")
                {
                    Console.WriteLine('+');
                    temp1 = myStack.Pop();
                    temp2 = myStack.Pop();
                    ans = Convert.ToDouble(temp2) + Convert.ToDouble(temp1);
                    myStack.Push(Convert.ToString(ans));
                    PrintValues(myStack);
                }
                else if (s == "-")
                {
                    Console.WriteLine('-');
                    temp1 = myStack.Pop();
                    temp2 = myStack.Pop();
                    ans = Convert.ToDouble(temp2) - Convert.ToDouble(temp1);
                    myStack.Push(Convert.ToString(ans));
                    PrintValues(myStack);
                }
                else if (s == "*")
                {
                    Console.WriteLine('*');
                    temp1 = myStack.Pop();
                    temp2 = myStack.Pop();
                    ans = Convert.ToDouble(temp2) * Convert.ToDouble(temp1);
                    myStack.Push(Convert.ToString(ans));
                    PrintValues(myStack);
                }
                else if (s == "/")
                {
                    Console.WriteLine('/');
                    temp1 = myStack.Pop();
                    temp2 = myStack.Pop();
                    ans = Convert.ToDouble(temp2) / Convert.ToDouble(temp1);
                    myStack.Push(Convert.ToString(ans));
                    PrintValues(myStack);
                }
                else if(s != " ")
                {
                    myStack.Push(s);
                    Console.WriteLine("(Push)\t\t{0}", s);
                    PrintValues(myStack);
                }

                i = i + count + 1;
            }

            Console.Write("Values:");
            PrintValues(myStack);

            ans = Convert.ToDouble(myStack.Peek());
            return ans;
        }

        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("{0}", obj);
            Console.WriteLine();
        }
    }
}
