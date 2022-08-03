using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._18june
{
    class Day
    {
        public static void Main(string[] args)
        {
            int day;
            Console.WriteLine("Enter Day :");
            day = int.Parse(Console.ReadLine());
            if(day==1)
            {
                Console.WriteLine("Monday");
            }
            else if(day==2)
            {
                Console.WriteLine("Tuesday");
            }
            else if(day==3)
            {
                Console.WriteLine("Wednesday");
            }
            else if(day==4)
            {
                Console.WriteLine("Thurday");
            }
            else if(day==5)
            {
                Console.WriteLine("Friday");
            }
            else if(day==6)
            {
                Console.WriteLine("Saturday");
            }
            else if(day==7)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
