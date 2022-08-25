using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._5Aug
{
    abstract class Vehicle
    {
        abstract public void Run();
        static int speed = 60;
        public string name = "bmw";
        const int price= 5000000;
       public Vehicle()
        {
            Console.WriteLine("Vehicle Run");
        }
        public void Travel()
        {
            Console.WriteLine("Speed:"+speed);
            
        }

    }
    class Car : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Car is Rinning......");
            Console.WriteLine("Name:"+name);
            //base.Travel();
        } 
    }
    class AbstractionDemo1
    {
        static void Main(string[] args)
        {
           Vehicle c = new Car();
            c.Run();
           c.Travel();
        }
    }
}
