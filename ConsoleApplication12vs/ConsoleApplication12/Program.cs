using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            Myclass2 myclass2 = new Myclass2();
            Myclass1 myclass1 = (Myclass1)myclass2;
            myclass1.numwidth = 3;
            myclass1.numheight = 4;
            Console.WriteLine(myclass1.Area());

            Console.WriteLine(myclass2.Area());
             


        }
    }
    class Myclass1
    {
        private double width=1;
        private double height=2;
        public double numwidth { get{ return width; }set { width = value; } }
        public double numheight { get { return height; }set { height = value; } }
        public  double Area()
        {
            return numheight * numwidth;
        }
    }
    class Myclass2 : Myclass1
    {
        double x = 3;
        double y = 3;
        public new  double Area()
        {
            return x * y;
        }
    }


}
