using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.SqlServer.Server;

namespace ConsoleApplication10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //实践与练习
            //1.开发一个程序实现字符串中的每个字符颠倒输出
            string str1 =Console.ReadLine();


            for (int i = 1; i<=str1.Length; i++)
            {
                Console.Write(str1.Substring(str1.Length-i,1));
            }























        }
    }
}