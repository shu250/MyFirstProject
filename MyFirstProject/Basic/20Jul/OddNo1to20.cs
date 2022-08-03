using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._20Jul
{
    class OddNo1to20
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd Number in between 1to20:");
            int i;
            for (i = 1; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
