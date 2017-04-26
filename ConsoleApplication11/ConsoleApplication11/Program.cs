using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApplication11
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //去除字符串中所有的空格
            /*
            string str = "hello world";
            Console.WriteLine(str.Remove(5,1));
*/

            //-----
            Console.WriteLine("please input u words");
            string str = Console.ReadLine();
            int num;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    Console.WriteLine(str.Remove(i,1));
                }




            }
















        }
    }
}