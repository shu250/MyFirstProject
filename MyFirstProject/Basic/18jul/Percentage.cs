using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._18june
{
    class Percentage
    {
        public static void Main(string[] args)
        {
            int sub1, sub2, sub3, sub4, sub5;
            Console.WriteLine("Enter sub1 Mark:");
            sub1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter sub2 mark:");
            sub2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter sub3 mark:");
            sub3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter sub4 Marks:");
            sub4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter sub5 Marks:");
            sub5 = int.Parse(Console.ReadLine());
            float per;
            per = (sub1 + sub2 + sub3 + sub4 + sub5) / 5;
            if (per >= 75)
            {
                Console.WriteLine("Distiction");
            }
            else if (per >= 60)
            {
                Console.WriteLine("First Class");
            }
            else if (per >= 50)
            {
                Console.WriteLine("Second Class");
            }
            else if (per >= 35) 
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }

        }
    }
}
