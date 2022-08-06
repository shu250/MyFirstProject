using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._3Aug
{

    class Animal
    {
        internal string food = "grass";

    }
    class Cow:Animal
    {
        internal string color =" black";
        public void Show()
        {
            Console.WriteLine(food+"  "+color);
        }
    }
    class AnimalInfo
    {
        static void Main(string[] args)
        {
            Cow a = new Cow();
            a.Show();
        }
    }
}
