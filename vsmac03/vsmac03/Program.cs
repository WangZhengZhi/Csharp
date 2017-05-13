using System;

namespace vsmac03
{
    interface People
    {
        string Name { get; set; }
        string Sex { get; set; }

    }
    interface Teacher : People
    {
        void teach();
    }
    interface Student : People
    {
        void study();
    }



    class Program : People, Teacher, Student
    {
        string name = "";
        string sex = "";
        public string Name { get { return name; } set { name = value; } }
        public string Sex { get { return sex; } set { sex = value; } }
        public void teach() { Console.Write(Name + "  " + Sex + "教师"); }
        public void study() { Console.WriteLine(Name + " " + Sex + "学生"); }



        static void Main(string[] args)
        {
            Program program = new Program();
            Teacher teacher = program;
            teacher.Name = "wang bo";
            teacher.Sex = "BOY";
            teacher.teach();
            Student student = program;
            student.Name = "wang zhengzhi";
            student.Sex = "BOY";
            student.study();

        }
    }
}
