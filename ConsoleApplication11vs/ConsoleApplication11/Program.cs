using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//自定义一个结构；结构中包含圆的半径以及求圆面积的方法，在Main函数中调用自定义结构求指定半径圆的面积

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1;
            circle1.r = 5;
            Console.WriteLine(circle1.Area());

        }
        public struct Circle
        {
            public double r;
          public Circle(double x)
            {
                r = x;
            }
          public double Area()
            {
                return Math.PI * r * r;
            }
                


        }

        

    }

}
