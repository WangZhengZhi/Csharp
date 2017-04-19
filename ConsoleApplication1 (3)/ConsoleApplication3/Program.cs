using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {  //课后作业问题
            //-------1
            //尝试开发一个程序，要求用“+”运算字符进行加法和串联字符串15；
            int num;
            num = 2;
            int sum = 0;
            sum += num;//加法
            Console.WriteLine("sum={0}",sum);
            string str0 = "1";
            string str1 = "5 ";
            string str = str0 + str1;
            Console.WriteLine(str);
            //---------2
            //用“？：”运算符进行赋值操作
            bool bls = true;
            int yesno=bls ? 1:2;
            Console.WriteLine(yesno);
            //---------3
            //通过++X和 X++求和
            int x;
            x = 0;
            Console.WriteLine("x++={0},++x={1}",x++,++x);




        }
    }
}
