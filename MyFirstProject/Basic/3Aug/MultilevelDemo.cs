using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._3Aug
{
    class Person
    {
        internal string name = "Ajay";
    }
    class Employee:Person
    {
        internal double sal = 30000;
    }
    class Manager:Employee
    {
        internal float commission = 1000;
        public void Show()
        {
            Console.WriteLine(name+" "+sal+" "+commission);
        }
    }
    class MultilevelDemo
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();
            m.Show();
        }
    }
}
