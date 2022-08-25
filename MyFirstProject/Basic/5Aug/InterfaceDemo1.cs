using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._5Aug
{
    interface IMovble
    {
        static string s = "Car";
        public void Move1();
        static void Show()
        {
            Console.WriteLine("Show Method");
        }
        public int Add()
        {
            return 10;
        }
        public void Display()
        {
            Console.WriteLine("hii");
        }
    }
    class Car1 : IMovble
    {
       public void Move1()
        {
            Console.WriteLine("Car is Moving.."+IMovble.s);
            
        }
    }
    class InterfaceDemo1
    {
        static void Main(string[] args)
        {
            IMovble c = new Car1();
            c.Move1();
            Console.WriteLine(c.Add());
            IMovble.Show();
            c.Display();
        }
    }
}
