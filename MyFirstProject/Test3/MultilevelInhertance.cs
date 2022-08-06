using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test3
{
    class Person
    {
        public string pname;
        public Person(string pname)
        {
            this.pname = pname;
        }
    }
    class Teacher : Person
    {
        public int id;
        public Teacher(int id) : base("RK")
        {
            this.id = id;
        }
        public void Teaching()
        {
            Console.WriteLine("Teaching Subject:Math");
        }
    }
    class Principal : Teacher
    {
        public Principal() : base(101)
        {
            Console.WriteLine("ID:" + id + "\nName:" + pname);
        }
        public void WorkingSchool()
        {
            Console.WriteLine("NACS");
        }
    }
    class MultilevelInhertance
    {
        
        static void Main(string[] args)
        {
            Principal p = new Principal();
            p.Teaching();
            p.WorkingSchool();

        }
    }
}
