using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test1
{
    class _6
    {
        static void Main(string[] args)
        {
            int i = 1;
            for (; i <= 100; i++)
            {
                if(i%3==0 && i % 5 == 0)
                {
                    Console.WriteLine("RedBlue");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Red");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Blue");
                }
            }
        }
    }
}
