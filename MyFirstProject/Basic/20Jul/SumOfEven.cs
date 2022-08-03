using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._20Jul
{
    class SumOfEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Start Number:");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter End Number:");
            int end = int.Parse(Console.ReadLine());
            int sum = 0, i;
            for (i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);

        }
    }
}
