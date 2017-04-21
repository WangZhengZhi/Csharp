using System;
using System.Collections.Generic;

namespace ConsoleApplication7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //温习下上次的内容
           /* DateTime dt = DateTime.Now;
            Console.WriteLine("{0}",string.Format("{0:F}",dt));
            string strb = string.Format("{0:f}", dt);
            Console.WriteLine(strb);
            strb = string.Format("{0:d}",dt);
            Console.WriteLine(strb);
            */
            //问题1：string 与String的区别
           /*______________比较字符串*/
            string str1 = "hello world";
            string str2 = "hello world";
            string str3 = "hello csharp";
            //String.Compare(string1,string2)
            Console.WriteLine(string.Compare(str1,str2));//str1=str2 value= 0;
            Console.WriteLine(string.Compare(str1,str3));//str1!=str3 value=1;
            Console.WriteLine(string.Compare(str3,str1));//str3!=str1  value=-1;
            //sring.Compare()
            Console.WriteLine(str1.CompareTo(str2));//str1=str1 value=0
            Console.WriteLine(str1.CompareTo(str3));//str1!=str3 value=1
            Console.WriteLine(str3.CompareTo(str1));//str3!=str1 value=-1
            //string1.Equals(sring2)
            //Equals(string1,strng2)
            Console.WriteLine(Equals(str1,str2));//str1=str2 value=True
            Console.WriteLine(Equals(str1,str3));//str1!=str3 value=False
            Console.WriteLine(str1.Equals(str2));//str1=str2 value=True
            Console.WriteLine(str1.Equals(str3));//str1!=str3 value=False




        }

    }
}