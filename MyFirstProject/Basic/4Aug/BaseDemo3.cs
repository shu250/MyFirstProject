using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._4Aug
{
    class Laptop
    {
        public Laptop()
        {
            Console.WriteLine("Laptop.............");
        }
    }
    class Dell : Laptop
    {
        public Dell()
        {
            Console.WriteLine("Dell Laptop............");
        }
    }
    class BaseDemo3
    {
        static void Main(string[] args)
        {


            Dell d = new Dell();
        }
    }
}
