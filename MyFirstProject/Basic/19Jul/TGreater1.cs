using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._19Jul
{
    class TGreater1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Third Number:");
            int num3 = int.Parse(Console.ReadLine());
            string result = num1 > num2 ? num1 > num3 ? num1 + " is Greater" : num3 + " is Greater" : num2 > num3 ? num2 + " is Greater" : num3 + " is Greater.";
            Console.WriteLine(result);


        }
    }
}
