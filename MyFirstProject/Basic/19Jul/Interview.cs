using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._19Jul
{
    class Interview
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Passing Year:");
            int py = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Percentage:");
            int per = int.Parse(Console.ReadLine());
            if(py>=2020)
            {
                if (per >= 60)
                {
                    Console.WriteLine("You are Eligible.");
                }
                else
                {
                    Console.WriteLine("You are not Eligible.");
                }
            }
            else
            {
                Console.WriteLine("You are not Eligible.");
            }
        }
    }
}
