using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._27Jul
{
    class Constuctor1
    {
        int roll_no;
        string name;
        double percentege;

        public void Consructor1()
        {
            roll_no = 10;
            name = "shubham";
            percentege = 70.80;
        }
        public void Display()
        {
            Console.WriteLine(roll_no+" "+name+" "+percentege);
        }

        static void Main(string[] args)
        {


            Constuctor1 c = new Constuctor1();
            c.Display();
        }
    }
}
