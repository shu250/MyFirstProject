using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._8Aug
{
    class SumOfNegative
    {
        static void Main(string[] args)
        {
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter Number:");
                int n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    sum = sum + n;
                }
                else if (n == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Positive Number:"+n);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
