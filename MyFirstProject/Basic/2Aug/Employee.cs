using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._2Aug
{
    class Employee
    {
        int id;
        string name;
        double salary;
        Department de;
        public Employee(int id,string name,double salary,Department de)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.de = de;
        }
        public void Show()
        {
            Console.WriteLine("Id:"+id+"\nName:"+name+"\nSalary:"+salary);
            de.Show1();
        }
        static void Main(string[] args)
        {
            Department d = new Department(101, "Hr");
            Employee e = new Employee(1, "Rahul", 25000, d);
            e.Show();
        }
    }
    class Department
    {
        int d_id;
        string d_name;

        public Department(int d,string name)
        {
            this.d_id = d;
            this.d_name = name;
        }
        public void Show1()
        {
            Console.WriteLine("Department Id:"+d_id+"\nDepartment Name:"+d_name);
        }
    }
}
