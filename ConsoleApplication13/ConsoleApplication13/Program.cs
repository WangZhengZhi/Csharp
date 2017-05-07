using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Permissions;

namespace ConsoleApplication13
{
    internal class Program
    {
        public static void Main(string[] args)
        {//switch语句
            //switch语句选择int 类型

           /*Console.WriteLine("please input u month ");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
               case 1:
                   case 2:
                   case 12:
                   case 11:
                   case 10:Console.WriteLine("winter!");
                   break;
               case 9:
                   case 8:
                   case 7:Console.WriteLine("autumn");
                   break;
               case 6:
                   case 5:
                   case 4:
                   case 3:Console.WriteLine("spring");
                   break;
                default:Console.WriteLine("wrong!!!! u input is wrong");
                    break;




            }*/
            /*___________选择string类型*/
            Console.WriteLine("please input u words");

            string str = Console.ReadLine();
            switch (str)
            {
                case "hello":
                    Console.WriteLine("hello");
                    break;
                case "world":
                    Console.WriteLine("world");
                    break;
                default:Console.WriteLine("wrong!!!");
                    break;

            }





        }
    }
}