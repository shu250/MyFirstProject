using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._28Jul
{
    class Student
    {
        int rno;
        double per;
        string clg;
        int s1, s2, s3, s4, s5;
        string name;
        string address;

        Student(int s1,int s2,int s3,int s4,int s5)
        {
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
            this.s4 = s4;
            this.s5 = s5;

        }
        Student() : this(70, 55, 66, 77, 88)
        {
            per = Convert.ToDouble((s1 + s2 + s3 + s4 + s5) / 5);
        }
        public void Accept(string clg,int rno,string name,string address)
        {
            this.clg = clg;
            this.rno = rno;
            this.name = name;
            this.address = address;
            this.Display();
        }
        public void Display()
        {
            Console.WriteLine("College Name:"+clg+"\nRoll No.:"+rno+"\nStudent Name:"+name+"\nAddress:"+address+"\nPercentage:"+per);
        }
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Accept("NACSCP", 10, "Subham", "Pune");
        }
    }
}
