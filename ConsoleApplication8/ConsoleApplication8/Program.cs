using System;
using System.Collections.Generic;
using Microsoft.SqlServer.Server;

namespace ConsoleApplication8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //--------截取字符串
            //string.Substring(int stratIndex,int length)
            //startIndexv:字符串的起始位置的索引
            //length ：截取的字符串的字符数
/*           string str1 = "hello world";
            string str2 = "";
            str2 = str1.Substring(0, 5);//
            Console.WriteLine(str2);
            //-----分割字符串
            string stra = "hello,how are ,u?";
            char[] str_flag = {',',','};//分割标志
            string [] splitthins=new string[100];//声明一个字符串数组
            splitthins = stra.Split(str_flag);//分割并赋值
            for (int i = 0; i < splitthins.Length; i++)
            {
                Console.WriteLine("第{0}句:{1}",i,splitthins[i]);

            }
            //------分割字符串习题
            string strb="hello,my people";
            char[] str_flagb = { ',',' '};
            string [] splitthinsb=new string[100];
            splitthinsb = strb.Split(str_flagb);
            for (int i = 0; i < splitthinsb.Length; i++)
            {
                Console.WriteLine("第{0}句话是：{1}",i,splitthinsb[i]);

            }
*/
            //插入和填充字符串
            //插入字符
            //string1.Insert(int startindex,string2)
            string str1 = "hello world";
            string str2 = "my";
            string str3;
            str3=str1.Insert(5,str2);
            Console.WriteLine(str3);
            Console.WriteLine(str1.Insert(5,str2));
            Console.WriteLine(str1.Insert(str1.Length,str2));
            //填充字符(Padright/Padleft)
            //string1.Pad(int totalwidth,padchar)
            //totalwidth:填充之后的字符串的长度
            //padchar:填充的字符
            string stra = "hello";
            string strb="";
            string strc="";
            strb = stra.PadLeft(6, '(');
            Console.WriteLine(strb);
            strc = strb.PadRight(7, ')');
            Console.WriteLine(strc);
            //Insert 方法实现Padleft /Padright
            string strd = "(";
            Console.WriteLine(stra.Insert(0,strd));
            //删除字符串
            //Remove
            //Remove(int startindex):startindex起始位置从0开始计数
            //Remove(int startidex,int count):count删除字符串的数量
            string string1 = "hello world";
            string string2 = "";
            string2 = string1.Remove(5);
            Console.WriteLine(string2);
            string2 = string1.Remove(0, 6);
            Console.WriteLine(string2);
            //----------复制字符串
            //String.Copy(string1)


            string a = "hello";
            string b = "world";
            string c = "";
            Console.WriteLine(string.Copy(b));
            c = string.Copy(b);
            Console.WriteLine(b);
            //CopyTo(int copystartindex,char[] str,int startindex,int count)
                        //copystartindex:需要复制的字符的起始位置
                        //char[] str:目标字符数组
                        //startindex指定目标数组中开始的位置
                        //count 指定复制的字数

            string string01 = "hello";
            char [] string02=new char[10];

            string01.CopyTo(0,string02,0,5);
            Console.WriteLine(string02);
            /*-------*/




















        }
    }
}