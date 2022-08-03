using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._18june
{
    class DivisibleBy5
    {
        public static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("Enter Number:");
            num1 = int.Parse(Console.ReadLine());
            if(num1%5==0)
            {
                Console.WriteLine(num1 + " is divisible by 5.");
            }
            else
            {
                Console.WriteLine(num1 + " is not divisible by 5.");
            }
        }
    }
}
