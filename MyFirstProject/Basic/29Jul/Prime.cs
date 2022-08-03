using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._29Jul
{
    class Prime
    {
        bool PrimeC(int n)
        {
            bool isPrime = true;
             for(int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
                           
            }
            return isPrime;
        }
        static void Main(string[] args)
        {
            Prime p = new Prime();
            Console.WriteLine("Enter Number:");
            int n = int.Parse(Console.ReadLine());
            bool a = p.PrimeC(n);
            if (a == true)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not Prime Number.");
            }


        }
    }
}

