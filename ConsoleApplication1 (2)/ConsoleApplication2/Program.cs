using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //其他特殊运算符
            //bool运算符
            /* int i = 0;
             bool result = i is int;
             Console.WriteLine(result);*/
            //条件运算符
            /* Console.WriteLine("输入年份");
             string str = Console.ReadLine();
             int year = Int32.Parse(str);//将string 转换为int 类型
             bool isleapyear = ((year % 4) == 0);
             string yesno = isleapyear ? "yes" : "no";
             Console.WriteLine("{0}year {1} leapyear",year,yesno);*/
            //new 运算符
            string[] ls = new string[5];
            //创建具有5个项目的string类型的数组
            ls[0] = "ls0";
            ls[1] = "ls1";
            ls[2] = "ls2";
            ls[3] = "ls3";
            ls[4] = "ls4";
            for(int i=0;i<=4;i++)
            {
                Console.WriteLine("{0}", ls[i]);
            }
            //typeof运算符
            Type mytype = typeof(int);//Type 是一个对象，Type类包含值得类型和引用类型的消息；
            Console.WriteLine("type={0}",mytype);
            Type utype = typeof(double);
            Console.WriteLine("type={0}",utype);
            //运算符优先等级
            //作为一个记忆内容
          





        }
    }
}
