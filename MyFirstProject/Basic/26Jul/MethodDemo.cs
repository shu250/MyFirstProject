using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._26Jul
{
    class MethodDemo
    {
        //no return type no parameter
        public void Display()
        {
            Console.WriteLine("Hello");
        }

        //no return With Parameter
        public void Cube(int a,string str)
        {
            Console.WriteLine("Cube="+a*a*a);
            Console.WriteLine(str);
        }

        //With returntype no Parameter
        public int Square()
        {
            return (2 * 2);
        }

        //With returntype With Parameter
        public int Addition(int a,int b)
        {
            return (a + b);
        }
        static void Main(string[] args)
        {
            MethodDemo a = new MethodDemo();
            a.Display();

            a.Cube(4, "Cube");

            int b = a.Square();
            Console.WriteLine(b);

            int c = a.Addition(10, 15);
            Console.WriteLine(c);
            Console.WriteLine(a.Addition(10,20));

        }
    }
}
