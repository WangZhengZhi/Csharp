using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 显示接口成员实现
/// </summary>
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Myclass myclass=new Myclass();
            Imyinterface1 imyMyinterface1 = myclass;
            Console.WriteLine(imyMyinterface1.Add());
            Imyinterface2 imMyinterface2 = myclass;
            Console.WriteLine(imMyinterface2.Add());

        }

    }

    interface Imyinterface1
    {
        int Add();

    }

    interface Imyinterface2
    {
        int Add();
    }

    class Myclass : Imyinterface1,Imyinterface2//继承接口
    {
        //求和方法
        int Imyinterface1.Add()
        {
            int x = 3;
            int y = 5;
            return x + y;
        }

        int Imyinterface2.Add()
        {
            int x = 3;
            int y = 5;
            int z = 7;
            return x + y+z;

        }


    }

}
