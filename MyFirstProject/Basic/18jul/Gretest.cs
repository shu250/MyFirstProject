using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._18june
{
    class Gretest
    {
        public static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter First Number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            if(num1>num2)
            {
                Console.WriteLine(num1 + " is Greater Number.");
            }
            else
            {
                Console.WriteLine(num2 + " is Greater Number.");
            }
        }
    }
}
