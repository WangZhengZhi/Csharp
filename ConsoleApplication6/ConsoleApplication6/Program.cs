using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ConsoleApplication6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
                //转义字符
            char a = '\'';
            Console.WriteLine(a);
            //让console.write() 与console.writeline()具有相同的效果；
            Console.Write("test\n");
            Console.WriteLine("test");
            //string 的使用
            /*string str0 = "i am a good boy";
            char  str1 = str0[0];
            char str2 = str0[1];
            Console.WriteLine("str1={0},str2={1}",str1,str2);
            */
            //比较字符的使用
            //Compare 存在一个ignorCase=true 不区分大小写的区别，否则区分
            string str0 = "我觉得我过的不错";
            string str1 = "我觉得我过的不错";
            Console.WriteLine(string.Compare(str0,str1));//0代表相同
            string str2 = "i am a good boy";
            string str3 = "i am not a good boy";
            Console.WriteLine(string.Compare(str2,str3));//-1&1代表不同
            //CompareTo
            //等于就是0，大于前一个大于后一个是1，否则是-1；
            Console.WriteLine(str3.CompareTo(str2));
            //Equals  相等就是true,否则就是false
            Console.WriteLine(str1.Equals(str1));
            Console.WriteLine(str1.Equals(str2));
            Console.WriteLine(string.Equals(str1,str1));
            Console.WriteLine(string.Equals(str1,str2));
            //---------格式化字符串
            string stra = "hello world";
            string strb="hello c#";
            string newstr = string.Format("{0},{1}",stra, strb);//拼接stra,strb;
            Console.WriteLine(newstr);
            //输出日期格式的各种形式
            DateTime dt=DateTime.Now;
            Console.WriteLine(dt);
            string dtformat = string.Format("{0:d}", dt);
            dtformat = string.Format("{0:D}", dt);
            dtformat = string.Format("{0:m}", dt);//M/m是一样的；
            dtformat = string.Format("{0:y}", dt);
            Console.WriteLine(dtformat);
            
















        }
    }
}