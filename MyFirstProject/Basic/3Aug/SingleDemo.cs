using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._3Aug
{
    class Mobile
    {
        protected string size = "64GB";

    }
    class Apple : Mobile
    {
        protected string model = "10pro";

        public void Show()
        {
            Console.WriteLine(model + " " + size);
        }
    }
    class SingleDemo
    { 
        static void Main(string[] args)
        {
            Apple a = new Apple();
            a.Show();
        }
    }
}
