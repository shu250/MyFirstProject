using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._5Aug
{
    interface IFatorble
    {
        public int Sum(int x);
    }
    class Division : IFatorble
    {
        public int Sum(int x)
        {
            int sum = 0;
            for(int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }
    }
    class SumOfFactor
    {
        static void Main(string[] args)
        {
            Division d = new Division();
            Console.WriteLine("Enter Number:");
            int n = int.Parse(Console.ReadLine());
            int a = d.Sum(n);
            Console.WriteLine("Sum of Factor:"+a);
        }
    }
}
