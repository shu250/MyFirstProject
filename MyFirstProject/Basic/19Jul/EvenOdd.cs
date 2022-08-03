using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._19Jul
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = int.Parse(Console.ReadLine());
            if(num%2==0)
            {
                
                if (num >= 2 && num <= 6)
                {
                    Console.WriteLine("Hi Even");
                }
                else
                {
                    Console.WriteLine("Only Even");
                }
            } 
            else
            {
                if (num >= 5 && num <= 10)
                {
                    Console.WriteLine("Hello Odd");
                }
                else
                {


                    Console.WriteLine("Only Odd");
                }
            }
        }
    }
}
