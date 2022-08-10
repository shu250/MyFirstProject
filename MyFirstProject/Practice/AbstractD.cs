using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Practice
{
    abstract class Flower
    {
        public abstract void Show();
        public void Display()
        {
            Console.WriteLine("Beautiful Flower");
        }
        public Flower(int i)
        {
            Console.WriteLine("Red Flower.");
        }
      
    }
    class Rose : Flower
    {
        public Rose() : base(10)
        {

        }
        public override void Show()
        {
            Console.WriteLine("Beawtiful Rose");
            base.Display();
        }

    }
    class AbstractD
    {
        static void Main(string[] args)
        {
           Rose r = new Rose();
            r.Show();
            r.Display();
        }

    }
}
