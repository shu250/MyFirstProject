using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._5Aug
{
   abstract class Animal
    {
        public abstract void Eat();
    }
    class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dog Eating.......");
        }
    }
    class AbstractDemo
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.Eat();

        }
    }
}
