using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//方法的重载
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();//实例化类对象
            int x = 1;
            int y = 2;
            int z = 3;
            double a = 1.2222;
            Console.WriteLine(Program.Add(x, y));
            Console.WriteLine(program.Add(x,a));
            Console.WriteLine(program.Add(x, y, z));
        }
        public static int Add(int x,int y)
        {
            return x + y;
        }
        public double Add(int x,double y)
        {
            return x + y;
        }
        public int Add(int x,int y,int z)
        {
            return x + y + z;
        }
    }
}
