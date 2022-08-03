using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._26Jul
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;
        public string  add;

        public void Accept(int eid, string ename, int esalary, string address)
        {
            id = eid;
            name = ename;
            salary =esalary;
            add = address;

        }
        public void Display()
        {
            Console.WriteLine(id+" "+name+" "+salary+" "+add);
        }
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Accept(1, "Shubham", 10000, "Ranjangaon");
            e.Display();
        }
    }
}
