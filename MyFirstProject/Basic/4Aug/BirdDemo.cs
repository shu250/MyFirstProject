using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._4Aug
{
    class Bird
    {
        public void Fly()
        {
            Console.WriteLine("Bird is Flying.");
        }
    }
    class Parrot : Bird
    {
        public void Fly()
        {
            Console.WriteLine("Parrot is Flying.");
            base.Fly();
        }
        
    }
    class BirdDemo
    {
        static void Main(string[] args)
        {
            Parrot p = new Parrot();
            p.Fly();
        }
    }
}
