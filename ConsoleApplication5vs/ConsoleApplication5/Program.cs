using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    //结构和类
    //1.结构的使用
    /* class Program
     {
         static void Main(string[] args)
         {
             Rect rect1;
             rect1.width = 13;
             rect1.height = 14;
             Console.WriteLine(rect1.Area());
             Rect rect2;
             rect2.width = 2;
             rect2.height = 3;
             Console.WriteLine(rect2.Area());
         }
         public struct Rect
         {
             public double width;
             public double height;
             public double Area()
             {
                 return width * height;

             }
         }

     }*/
    class Program
    {
        public struct Rect
        {
            public double width;
            public double height;
            public Rect(double x,double y)
            {
                width = x;
                height = y;
            }
            public double Area()
            {
                return width * height;

            }

        }
        public static void Main(string[] args)
        {
            Rect rect1 = new Rect(2,3);
            Console.WriteLine(rect1.Area());

            
        }

    }

}
