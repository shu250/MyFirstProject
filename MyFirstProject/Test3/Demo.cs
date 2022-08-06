using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test3
{
    class Demo
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.color = "Blue";
            Car c2 = new Car();
            c2.ChangeColor(c1);
            c2.color = "Pink";
            Console.WriteLine(c1.color);
            Console.WriteLine(c2.color);
        }
    }
    class Car
    {
       public string color;
        public void ChangeColor(Car c2)
        {
            c2.color = color;
            color = "Red";
        }
    }
}
