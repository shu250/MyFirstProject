
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test4
{
    class _13
    {
        public static void Display()
        {
            int t = 0, f = 0, tf = 0;
            for(int i = 0; i <= 50; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("buzz");
                    t++;
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("fizz");
                    f++;
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("buzzfizz");
                    tf++;
                }
            }
            Console.WriteLine("Total buzz: "+t);
            Console.WriteLine("Total fizz: " + f);
            Console.WriteLine("Total buzzfizz: " + tf);
        }
        static void Main(string[] args)
        {
            _13.Display();
        }
    }
}
