using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//类的继承
namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Myclass1 myclass1 = new Myclass1();
            Myclass2 myclass2 = new Myclass2();
            myclass1.numx = 1;
            myclass1.numy = 2;
            myclass2.numx = 1;
            myclass2.numy = 1;
            myclass2.numz = 1;
            Console.WriteLine(myclass1.Add1());
            Console.WriteLine(myclass2.Add1());
            Console.WriteLine(myclass2.Add2());

        }
    }
    class Myclass1
    {
        private int x = 0;
        private int y = 0;
        public int numx { get { return x; }set { x = value; } }
        public int numy { get{ return y; }set { y = value; } }
        public int Add1()
        {
            return numx + numy;

        }
    }
    class Myclass2:Myclass1
    {
        private int z = 0;
        public int numz{get{ return z; }set { z = value; } }
        public int Add2()
        {
            return numx + numy + numz;
        }
    }


}
