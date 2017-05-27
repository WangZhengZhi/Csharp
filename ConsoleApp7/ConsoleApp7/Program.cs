using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 抽象类与抽象方法
/// </summary>
namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
           DriveClass driveclass=new DriveClass();
            Myclass myclass = driveclass;
            myclass.ID = "15426037";
            myclass.NAME = "zhengzhi";
            myclass.ShowInfo();

        }
    }

    public abstract class Myclass
    {
        private string id  ;
        private string name;
        public string ID {
            get { return id; }
            set { id = value; }
        }
        public string NAME {
            get { return name; }
            set { name = value; }
        }
        public abstract void ShowInfo();

    }
    public class DriveClass : Myclass
    {
        public override void ShowInfo()
        {
            Console.WriteLine(ID + " " + NAME);
        }
    }




}
