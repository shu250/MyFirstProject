using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._4Aug
{
    class Employee
    {
        public Employee(string n)
        {
            Console.WriteLine("Name:"+n);
        }
    }
    class Manager : Employee
    {
       public Manager(float sal,float exp):base("Shu")
        {
            Console.WriteLine("Salary:"+sal+"Experience:"+exp);
        }
    }
    class BaseDemo4
    {
        static void Main(string[] args)
        {
            Manager m = new Manager(12000, 5.4f);
        }
    }
}
