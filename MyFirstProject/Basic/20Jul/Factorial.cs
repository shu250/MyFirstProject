using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._20Jul
{
    class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = int.Parse(Console.ReadLine());
            int fact=1;
            for(int i=1;i<=num;i++)
            {
                fact = fact * i;

            }
            Console.WriteLine(num + " Factorial is " + fact);
        }
    }
}
