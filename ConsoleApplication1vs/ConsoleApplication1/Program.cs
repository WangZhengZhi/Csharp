using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    //第八章
    //属性和方法


    class Program
    {
        static void Main(string[] args)
        {
            //属性
            
            Myclass myclass = new Myclass();
            myclass.ID = "15426037";
            myclass.NAME = "zhengzhi";
            Console.WriteLine(myclass.ID+" is "+myclass.NAME);
            myclass.ID = "15426033";
            myclass.NAME = "wangbo";
            Console.WriteLine(myclass.ID+" is "+myclass.NAME);
            Console.WriteLine(Program.ADD(2, 3));
            Program program = new Program();//实例化类对象
            Console.WriteLine(program.ADD0(3,3));


            

        }
        public void Menthod()
        {
            Console.WriteLine("hello world");

        }//方法的声明
        public static int ADD(int x,int y)
        {
            return x + y;
            //static静态方法


        }
        public int ADD0(int x,int y)

        {
            return x + y;
        }
        
    }
    /*public class Date
    {
        private int Day = 7;
        public int day
        {
            get{return Day; }
            set{
                if(day>0&&day<8){ Day = value;}
               }

        }

    }*/
    //属性的使用
     class Myclass
    {
        string id;
        string name;
        public string ID { get { return id; }set { id = value; } }
        public string NAME { get { return name; }set { name = value; } }




    }
   
}
