using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._20Jul
{
    class OddEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = int.Parse(Console.ReadLine());
            int a = num % 2;
            switch (a)
            {
                case 1:Console.WriteLine("Odd Number.");
                    break;
                case 0:Console.WriteLine("Even Number.");
                    break;
            }
        }
    }
}
