using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._4Aug
{
    class Animal
    {
        public int leg = 4;
    }
    class Frog : Animal
    {
        internal int leg = 2;
        public void Show()
        {
            Console.WriteLine(leg+" "+base.leg);
        }
    }
    class BasicDemo
    {
        static void Main(string[] args)
        {


            Frog f1 = new Frog();
            f1.Show();
        }
    }
}
