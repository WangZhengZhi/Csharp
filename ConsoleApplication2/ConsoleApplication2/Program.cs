using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;

namespace ConsoleApplication2
{


    class Program
    {
        enum Mydate
        {
            sun=0,mon=1,tue=2,wed=3,thi=4,fri=5,sat=6
        }

        static void Main(string[] args)
        {
            int k = (int) DateTime.Now.DayOfWeek;
            switch (k)
            {
               case (int)Mydate.sun:Console.WriteLine("周日");
                   break;
               case (int)Mydate.mon:Console.WriteLine("周一");
                   break;
               case (int)Mydate.tue:Console.WriteLine("周二");
                   break;
               case (int)Mydate.wed:Console.WriteLine("周三");
                   break;
               case (int)Mydate.thi:Console.WriteLine("周四");
                    break;
               case (int)Mydate.fri:Console.WriteLine("周五");
                   break;
                case (int)Mydate.sat:Console.WriteLine("周六");
                    break;

            }


        }


    }

}