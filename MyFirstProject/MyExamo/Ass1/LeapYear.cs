using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.MyExamo.Ass1
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year:");
            int y = int.Parse(Console.ReadLine());
            if (y % 4 == 0)
            {
                if (y % 100 != 0)
                {
                    Console.WriteLine("Leap Year");
                }
                else
                {
                    Console.WriteLine("Not Leap Year.");
                }
            }
            else if (y % 400 == 0)
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not Leap Year.");
            }
        }
    }
}
