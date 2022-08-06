using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._4Aug
{
    class Fruit
    {
        public virtual void Test()
        {
            Console.WriteLine("Fruit is sweet....");
        }
    }
    class Mango : Fruit
    {
        public override void Test()
        {
            Console.WriteLine("Mango is sweet...");
        }
    }
    class OverridingDemo
    {
        static void Main(string[] args)
        {
            Fruit f = new Mango();
            f.Test();
        }
    }
}
