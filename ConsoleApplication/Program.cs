using System;
using System.Collections.Generic;



class Program
{
    class C
    {
        public int value = 0;
    }

    static void Main(string[] args)
    {
        int v1 = 0;
        int v2 = v1;
        v2 = 927;
        C r1=new C();
        C r2 = r1;
        r2.value = 112;
        Console.WriteLine("value{0},{1}",v1,v2);
        Console.WriteLine("refs{0},{1}",r1.value,r2.value);
        Console.ReadLine();
    }


}
