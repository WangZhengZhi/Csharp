using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//类的多态
namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            Myclass2 myclass2 = new Myclass2();
            Myclass1 myclass1 = (Myclass1)myclass2;
            myclass1.numx = 4;
            myclass1.numy = 4;
            Console.WriteLine(myclass1.Add());
            Console.WriteLine(myclass2.Add());

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
        }//定义一个Virtual类型的方法，以便子类中重写该方法
    }
    class Myclass2:Myclass1
    {
        public override int Add()
        {
            int x = 5;
            int y = 5;
            return x + y;

        }//override重写基类方法
    }


}
