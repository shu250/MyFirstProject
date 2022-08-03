using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._29Jul
{
    class AdditionPrime
    {
        public int Prime(int n)
        {
            int sum = 0;
            bool isPrime = true;
            for (int i = 1; i <= n; i++)
            {
               
                
                for(int j = 2; j < i; j++)
                {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                }
             
                if (isPrime == true)
                {
                    sum = sum + i;
                }
               
            }
            return sum;
        }
        static void Main(string[] args)
        {
            AdditionPrime a = new AdditionPrime();
            Console.WriteLine("Enter range:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum of Prime Number:"+a.Prime(n));

        }
    }
}
