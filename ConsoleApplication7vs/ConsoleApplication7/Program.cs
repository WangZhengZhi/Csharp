using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//类的封装
namespace ConsoleApplication7
{
    /* class Program
     {
         static void Main(string[] args)
         {
             Myclass myclass = new Myclass();
             myclass.numx = 3;
             myclass.numy = 4;
             Console.WriteLine(myclass.Add());

         }
     }
     class Myclass
     {
         private int x = 0;
         private int y = 0;
         public int numx { get { return x; }set {  x=value; } }
         public int numy { get { return y; }set {  y=value; } }
         public int Add()
         {
             return  numx+numy;

         }

     }
     */
    class Program
    {
        static void Main(string[] args)
        {
            Myclass myclass = new Myclass();
            myclass.numx = 1;
            myclass.numy = 2;
            Console.WriteLine(myclass.Add());

        }

    }
    class Myclass
    {
        private int x = 0;
        private int y = 0;
        public int numx { get { return x; }set { x = value; } }
        public int numy { get { return y; }set { y = value; } }
        public int Add()
        {
            return numx + numy;
        }

    }



}
