using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication9
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            //_________替换字符串
            //string Replace(char old_char,char new_char)//替换的是字符串中的内容
            //string Replace(string old_string,sring new_string)
            //
  /*        string a = "hello world";
            string b = a.Replace('o', 'i');
            Console.WriteLine(b);
            string c = "nice to meet u";
            b = a.Replace(a, c);
            Console.WriteLine(b);
*/

            //_________可替换字符串的使用
            //StringBuild的类的定义
            //StringBuild(string value,int cap)
            //value :对象引用的字符串
            //cap:设定StringBuild对象的初始大小
            //StringBuilder mystringbuile=new StringBuilder("hello world");
            /*****--------------------------------------------------****/
            //StringBuild类的使用
            //Append:将文本或者字符串追加到指定对象的末尾
            //AppendFomat:自定义变量的格式并将这些值追加到StringBuild对象的末尾
            //Insert:将字符串或者对象添加到当前StringBuild对象的指定位置
            //Remove从当前StringBuild对象中移除指定数量的字符
            //Replace用另一个指定的字符来替换StringBuild对象内的字符
            StringBuilder mystringbuild=new StringBuilder("hello worl",100);
            mystringbuild = mystringbuild.Append('d');
            Console.WriteLine(mystringbuild);
            int num = 100;
            mystringbuild = mystringbuild.AppendFormat("{0}", num);
            Console.WriteLine(mystringbuild);
            mystringbuild = mystringbuild.Insert(mystringbuild.Length, "nice to meet u");
            Console.WriteLine(mystringbuild);
            mystringbuild = mystringbuild.Remove(14, mystringbuild.Length - 14);
            //Remove(int start,int end);strat：起始位置，end:结束位置
            Console.WriteLine(mystringbuild);
            mystringbuild.Replace("hello","HELLO");
            //Replace("old_string","new_string");
            //Replace('old_char','new_char');


            Console.WriteLine(mystringbuild);










        }
    }
}