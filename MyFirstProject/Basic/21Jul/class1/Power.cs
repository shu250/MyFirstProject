using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._21Jul.class1
{
    class Power
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Base:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Exponent:");
            int e = int.Parse(Console.ReadLine());
            int i = 1;
            int p=1;
            while(i<=e)
            {
                p = p * e;
                i++;
            }
            Console.WriteLine(p);
        }
    }
}
