using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program:Ipeople,Istudent,Iteach
    {
        string name;
        string sex;
        public string NAME { get { return name; }set { name = value; } }
        public string SEX { get { return sex; }set { sex = value; } }
        public void teach()
        {
            Console.WriteLine(NAME + " " + SEX + " " + "教师");
        }
        public void study()
        {
            Console.WriteLine(NAME + " " + SEX + " " + "学生");

        }

        static void Main(string[] args)
        {
            Program program = new Program();
            Iteach iteach = program;
            iteach.NAME = "zhengzhi";
            iteach.SEX = "boy";
            iteach.teach();
            Istudent istudent = program;
            istudent.NAME = "wangbo";
            istudent.SEX = "boy";
            istudent.study();

        }
    }
    interface Ipeople
    {
        string NAME { get; set; }
        string SEX { get; set; }

    }
    interface Istudent : Ipeople
    {
        void study();

    }
    interface Iteach : Ipeople
    {
        void teach();
    }




}
