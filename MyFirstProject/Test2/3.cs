using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test2
{
    class _3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int n = int.Parse(Console.ReadLine());

            int s = n * n;
            int n1 = n;
            int c = 0;
            while (n1 > 0)
            {
                c++;
                n1 = n1 / 10;
            }
            int p = 1;
            while (c > 0)
            {
                p = p * 10;
                c--;
            }
            int a = s % p;
            int b = s / p;
            int sum = a + b;
            if (n == sum)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
