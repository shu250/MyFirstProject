
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.MyExamo.Ass2
{
    class SumOfFactorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter end of Series:");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                int fact = 1;
                for(int j = 1; j <= i; j++)
                {
                    fact = fact * j;
                }
                sum = sum + fact;
            }
            Console.WriteLine(sum);
        }
    }
}
