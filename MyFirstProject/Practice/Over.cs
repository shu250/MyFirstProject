using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Practice
{
    class Fruit
    {
        public  void Test()
        {
            Console.WriteLine("Test is sweet.");
        }
    }
    class Mango : Fruit
    {
        public  void Test()
        {
            Console.WriteLine("Mango is Sweet.");

        }
    }
    class Over
    {
       
        static void Main(string[] args)
        {
            Mango m = new Mango();
            m.Test();
        }
    }
}
