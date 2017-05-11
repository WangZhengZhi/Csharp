using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//结构与类
//2.类的使用
//对象声明和实例化
namespace ConsoleApplication6
{
    class Myclass
    {
        public int x = 0;
        public int y = 0;
        public int z = 0;
        public int numx { get { return x; } set { x = value; } }
        public int numy { get { return y; } set { y = value; } }
        public int numz { get { return z; } set { z = value; } }
        public Myclass()
        {

        }//构造函数
    }
    class Program
    {
       /* public int x = 3;
        public int y = 4;
        public int z = 0;
        public Program()
        {
            z = x + y;
        }//构造函数
        ~Program()
        {
            Console.WriteLine("析构函数");//一个类只能有一个析构函数，并且是无法调用的，他会自动被调用
        }*/
        static void Main(string[] args)
        {
            /*Program program = new Program();
            Console.WriteLine(program.z);*/
            int x = 3;
            int y = 5;
            Myclass myclass = new Myclass();
            myclass.numx = x;
            myclass.numy = y;
            myclass.numz = myclass.x + myclass.y;
            int z = myclass.numz;
            Console.WriteLine(z);

        }
        
       
        
        
        
      

        



    }
}
