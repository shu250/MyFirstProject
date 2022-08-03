using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test1
{
    class _5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());
            int num1 = num;
            int sum = 0;
            while (num1 > 0)
            {
                sum = sum + num1 % 10;
                num1 = num1 / 10;
            }
            if (num % sum == 0)
            {
                Console.WriteLine("Harshad Number.");
            }
            else
            {
                Console.WriteLine("Not Harshad Number.");
            }
        }
    }
}
