using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._3Aug
{
    class Vehicle
    {
        internal int cwheel = 4;
        internal int twheel = 8;
    }
    class Car : Vehicle
    {
        internal string name = "BMW";
        public void Show()
        {
            Console.WriteLine(name+" "+cwheel);
        }
    }
    class Truck : Vehicle
    {
        internal string name = "Eicher";
        public void Show()
        {
            Console.WriteLine(name+" "+twheel);
        }
    }
    class HierarchicleDemo
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Show();
            Console.WriteLine("-------------------------------------");
            Truck t = new Truck();
            t.Show();

        }
    }
}
