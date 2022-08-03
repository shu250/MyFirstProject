using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._18june
{
    class Positive
    {
        public static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("Enter number:");
            num1 = int.Parse(Console.ReadLine());
            if(num1>0)
            {
                Console.WriteLine("Number is Positive.");

            }
            else if(num1<0)
            {
                Console.WriteLine("Number is Negative.");
            }
            else
            {
                Console.WriteLine("Number is Zero");
            }
        }
    }
}
