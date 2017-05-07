using System;
using System.Collections.Generic;

namespace ConsoleApplication15
{
    internal class Program
    {
        public static void Main(string[] args)
        {
                //第六章实践与练习
            //1.尝试开发一个程序，要求判断变量I大于等于6时，输出1 的值
            /*int i=8;

            while (i >= 6)
            {
                Console.WriteLine("i={0}",i);
                break;

            }*/
            //2.goto语句跳转到指定位置
            /*int[] num = {1, 2, 3, 4, 5, 6, 7};
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > 5)
                {

                    goto FOUND;

                }


            }
            goto FINISH;
            FINISH:Console.WriteLine("seach is complete");
            FOUND:Console.WriteLine("found a num >5");
            */
            //3.用switch case语句判断整数的范围
            int[] num = {9,19,29,39};
            for (int i = 0; i < num.Length; i++)
            {
                switch (num[i] / 10)
                {
                    case 0:Console.WriteLine("num={0} under 10",num[i]);
                        break;
                    case 1:Console.WriteLine("num={0} under 20",num[i]);
                        break;
                    case 2:Console.WriteLine("num={0} under 30",num[i]);
                        break;
                    default:Console.WriteLine("num={0} over 30",num[i]);
                        break;
                }

            }






        }
    }
}