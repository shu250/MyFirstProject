using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._3Aug
{
    class Teacher
    {
        internal int tid = 101;
        internal int tid1 = 102;
    }
    class JavaTeacher : Teacher
    {
        internal string name = "Rahul sir";
        public void Show()
        {
            Console.WriteLine(tid+" "+name);
        }
    }
    class PythonTeacher:Teacher
    {
        internal string name = "Satish sir";
        public void Show()
        {
            Console.WriteLine(tid1+" "+name);
        }
    }
    class TeacherInfo
    {
        static void Main(string[] args)
        {
            PythonTeacher p = new PythonTeacher();
            p.Show();
            JavaTeacher j = new JavaTeacher();
            j.Show();
        }
    }
}
