using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._28Jul
{
    class Mobile
    {
        int price;
        string name;
        string memory;
        public Mobile()
        {
            Console.WriteLine("I am Default");
        }
        public Mobile(string name)
        {
            this.name = name;
        }
        public Mobile(int price,string memory)
        {
            this.price = price;
            this.memory = memory;
        }
        public void Show()
        {
            Console.WriteLine("Mobile Name:"+name);
        }
        public void Show1()
        {
            Console.WriteLine("Price: "+price+"\nMemory: "+memory);
        }
    }
    class ConstructorV
    {
        static void Main(string[] args)
        {
            Mobile m = new Mobile();
            Mobile m1 = new Mobile("Apple");
            Mobile m2 = new Mobile(30000, "128GB");
    
            m1.Show();
            m2.Show1();
        }
    }
}
