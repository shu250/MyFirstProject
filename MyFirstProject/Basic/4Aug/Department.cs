using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._4Aug
{
    class Department
    {
        public int did = 10;
        public void Display()
        {
            Console.WriteLine("New Art College");
        }
        public Department(int tot)
        {
            Console.WriteLine("No of Teacher:"+tot);
        }
    }
    class BcsDepartment : Department
    {
        public int did = 11;
        public BcsDepartment(int tot_student) : base(15)
        {
            Console.WriteLine("Total Student:"+tot_student);
        }
        public void Display()
        {
            Console.WriteLine("Id:"+did+"\nDepartment Id:"+base.did);
            base.Display();
        }

    }
    class DepartmentB
    {
        static void Main(string[] args)
        {


            BcsDepartment b = new BcsDepartment(105);
            b.Display();

        }
    }
}
