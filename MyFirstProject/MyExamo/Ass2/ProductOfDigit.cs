using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.MyExamo.Ass2
{
    class ProductOfDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int n = int.Parse(Console.ReadLine());
            int p=1;
            while (n > 0)
            {
                int d = n % 10;
                p = p * d;
                n = n / 10;
            }
            Console.WriteLine(p);
        }
    }
}
