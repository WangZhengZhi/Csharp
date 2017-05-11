using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//自定义类中定义一个星期的属性，最大值不能大于7
namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class Myday
    {
        private int day=7;
        public int  Day
        {
            get { return day; }
            set
            {
                if (day > 0 && day < 8)
                { day = value; }
            }
        }
       


        
       
    }

    

}
