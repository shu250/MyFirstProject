using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test3
{
    class Laptop
    {
        public int Price;
        public Laptop(int Price)
        {
            this.Price = Price;
        }
        public void Watch()
        {
            Console.WriteLine("Watching Movie");
        }
    }
    class Dell : Laptop
    {
        public int Price = 40000;
        public Dell():base(35000)
        {
            Console.WriteLine("Name:Dell");
        }
        public void Show()
        {
            Console.WriteLine("Price:"+Price+"\nOld Price"+base.Price);
            base.Watch();
        }
    }

    class Base
    {
        static void Main(string[] args)
        {
            Dell d = new Dell();
            d.Show();
        }
    }
}
