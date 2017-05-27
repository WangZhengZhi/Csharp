using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//密封类与密封方法
namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Myclass2 myclass2=new Myclass2();
            myclass2.ID = "15426037";
            myclass2.NAME = "zhengzhi";
            myclass2.ShowInfo();
        }
    }

    /*public class Myclass1
    {
        public virtual void Menthod()
        {
            Console.WriteLine("基类中的虚方法");
        }
    }

    public sealed class Myclass2 : Myclass1
    {
        public sealed override void Menthod()
        {
            base.Menthod();
            Console.WriteLine("密封类中重写后的方法");//密封并重写基类中的虚方法Menthod()
        }
    }*/
    public class Myclass1
    {
        public virtual void ShowInfo()
        {
            
        }//虚方法，用来显示信息
    }

    public sealed class Myclass2 : Myclass1
    {
        private string id;
        private string name;
        public string ID
        {
            get { return id; }
            set { id = value; }

        }

        public string NAME
        {
            get { return name; }
            set { name = value; }

        }

        public sealed override void ShowInfo()
        {
            Console.WriteLine(ID+" "+NAME);
        }
    }
    ///10.4小结
    /// 接口
    /// 抽象类
    /// 抽象方法
    /// 密封类
    /// 密封方法
    

    
    


}
