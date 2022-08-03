using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._18june
{
    class EvenOdd
    {
        public static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("Enter Number:");
            num1 = int.Parse(Console.ReadLine());
            if(num1%2==0)
            {
                Console.WriteLine(num1 + "is Even Number.");
            }
            else
            {
                Console.WriteLine(num1 + "is Odd Number.");
            }

        }
    }
}
