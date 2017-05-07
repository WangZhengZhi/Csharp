using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication14
{
    internal class Program
    {
        static string mystr(string str)
        {
            string outstr;
            outstr = "您输入的数据是 "+str;
            return outstr;
        }
        public static void Main(string[] args)
        {
            //while 语句的使用
            //迭代语句
           /* int[] myint = new int[6]
            {
                1, 2, 3, 4, 5, 6
            };
            int sum = 0;
            int i = 0;
            while (i < 6)
            {
              Console.WriteLine("int[{0}]={1}",i,myint[i]);
                sum += myint[i];

                i++;

            }
            Console.WriteLine("sum={0}",sum);
            */
            /*_______while continue break的用法__________________*/
            /*int sum = 0;
            int num = 80;
            while (sum < num)
            {
                sum++;
                if (sum > 40)
                {
                    break;
                }
                if (sum % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine("sum={0}",sum);



            }*/
           /*_____________do while 语句的使用_____________*/
            /*int[] myint = new int[5] {0,1,2,3,4 };
            bool term = false;
            do
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("{0}", myint[i]);
                }

            } while (false);
             */
            /*_______for 语句的使用——————————————————*/
            /*int[] myint=new int[6];
            for (int i = 0; i < 6; i++)
            {
                myint[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("myint[{0}]={1}",i,myint[i]);

            }
            */
            /*_______________________foreach的用法__________________*/
            /*ArrayList num=new ArrayList();
            num.Add(1);
            num.Add(2);
            num.Add(3);
            num.Add(4);
            foreach (int num_each in num)
            {
               Console.WriteLine(num_each);
            }
            ArrayList str=new ArrayList();
            str.Add("hello");
            str.Add("world");
            str.Add("nice to meet u");
            foreach (string str_each in str)
            {
                Console.WriteLine(str_each);
            }
            */
            /*_________goto语句的使用_______*/
           /* Console.WriteLine("please input u want seach number");
            int[] myint = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < myint.Length; i++)
            {
                if (myint[i] == num)
                {
                    goto FOUND;
                }



            }
            Console.WriteLine("u seach num isnot here");
            goto FINISH;
            FOUND:Console.WriteLine("seach num={0}",num);
            FINISH:Console.WriteLine("seach is complete");
            */
            /*__________________________return 语句___________________________*/


            Console.WriteLine("请输入内容");
            string inputstr = Console.ReadLine();
            Console.WriteLine(mystr(inputstr));









        }


    }
}