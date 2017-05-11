using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Myclass2 myclass2 = new Myclass2();
            Myclass1 myclass1 = (Myclass1)myclass2;
            myclass1.numx = 1;
            myclass1.numy = 2;
            Console.WriteLine(myclass1.Add());//1+2
            Console.WriteLine(myclass2.Add());//1+1

        }
    }
    class Myclass1
    {
        private int x = 0;
        private int y = 0;
        public int numx { get { return x; }set { x = value; } }
        public int numy { get { return y; }set { y = value; } }
        public virtual int Add()
        {
            return numx + numy;

        }
    }
    class Myclass2:Myclass1
    {
        public new int Add()
        {
            int x = 1;
            int y = 1;
            return x + y;

        }
    }


}
