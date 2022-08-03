using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._19Jul
{
    class TEvenOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = int.Parse(Console.ReadLine());
            string result = num % 2 == 0 ? "Even Number" : "Odd Number";
            Console.WriteLine(result);
        }
    }
}
