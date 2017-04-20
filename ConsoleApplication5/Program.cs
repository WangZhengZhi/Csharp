using System;
using System.Collections.Generic;

namespace ConsoleApplication5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //字符串与字符
            //第五章
            char a = 'a';
            char b = 'B';
            char num = '8';

            Console.WriteLine("a={0}",char.IsLetter(a));//判断a是不是字母
            Console.WriteLine("num={0}",char.IsDigit(num));//判断num是不是数字
            Console.WriteLine("num={0},a={1}",char.IsLetterOrDigit(num),char.IsLetterOrDigit(a));
            //判断num 是不是数字或者字母，判断a是不是数字或者字母；
            Console.WriteLine("b={0}",char.IsUpper(b));//判断b是不是大写的字母
            Console.WriteLine("a={0}",char.IsLower(a));//判断a是不是小写的字母
            char c = ' ';
            Console.WriteLine("c={0}",char.IsWhiteSpace(c));//判断c是不是空格
            char d = '|';
            Console.WriteLine("e={0}",char.IsSeparator(d));//判断d是不是分隔符
            






        }
    }
}