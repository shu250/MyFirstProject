using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._4Aug
{
    class Mobile
    {
        public string size;
        public string color;
        public Mobile(string size,string color)
        {
            this.size = size;
            this.color = color;
        }
        public void Display()
        {
            Console.WriteLine("Memory size:"+size);
        }
    }
    class Samsung : Mobile
    {
        public string color;
        public Samsung(string color) : base("64GB", "White")
        {
            this.color = color;
        }
        public Samsung() : this("Golden")
        {
            Console.WriteLine("Model:Galaxy");
        }
        public void Display()
        {
            Console.WriteLine("Color:"+color);
            base.Display();

        }
        public void Show()
        {
            Console.WriteLine("Available Color:"+base.color);
            this.Display();
        }

    }
    class ThisBase
    {
        static void Main(string[] args)
        {


            Samsung s = new Samsung();
            s.Show();
        }
    }
}
