using System;

namespace vsmac02
{
    interface Myinterface
    {
        string ID { get; set; }
        string NAME { get; set; }
        void ShowInfo();
        {
            Console.WriteLine("编号\t+姓名");
            Console.WriteLine(ID+"\t"+NAME);

        }



}

class Program : Myinterface
{
    string id = "";
    string name = "";
    public string ID { get { return id; } set { id = value; } }
    public string NAME { get { return name; } set { name = value; } }
    public void ShowInfo()
    {
        Console.WriteLine("编号\t+姓名");
        Console.WriteLine(ID + "\t" + NAME);
    }


    static void Main(string[] args)
    {
        Program program = new Program();
        Myinterface myinterface = program;


    }

}
