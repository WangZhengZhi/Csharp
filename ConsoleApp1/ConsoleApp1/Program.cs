using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//接口问题-第十章
namespace ConsoleApp1
{
    interface Imyinterface
    {
        string ID { get; set; }
        string NAME { get; set; }
        void ShowInfo();
        


    }
    class Program:Imyinterface
    {
        string id="";
        string name="";
        public string ID { get { return id; }set { id = value; } }
        public string NAME { get { return name; }set { name = value; } }
        public void ShowInfo()
        {
            Console.WriteLine("id \t name");
            Console.WriteLine(ID+"\t"+NAME);
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            Imyinterface imyinterface = program;
            imyinterface.ID = "15426037";
            imyinterface.NAME = "zhengzhi";
            imyinterface.ShowInfo();



        }
    }
   

}
