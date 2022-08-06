using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._5Aug
{
    interface IMovable
    {
        public void Move();
    }
    class Bus : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bus is Moving......");
        }
    }
    class InterfaceDemo
    {
        
        static void Main(string[] args)
        {
            Bus b = new Bus();
            b.Move();

        }
    }
}
