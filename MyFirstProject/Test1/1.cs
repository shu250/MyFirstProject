using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test1
{
    class _1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers Between 1 TO 100 except Which are Divisible by 5 or 10");
            int i = 1;
            for (; i <= 100; i++)
            {
                if (i % 5 == 0 || i % 10 == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
