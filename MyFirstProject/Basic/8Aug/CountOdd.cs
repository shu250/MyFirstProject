using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._8Aug
{
    
    class CountOdd
    {
        public int Odd(int[] a)
        {
            int c = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    c++;
                }
            }
            return c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array size:");
            int s = int.Parse(Console.ReadLine());
            int[] a = new int[s];
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter Size of array:");
                a[i] = int.Parse(Console.ReadLine());
            }
            CountOdd c = new CountOdd();
            Console.WriteLine("Total Odd Number:"+c.Odd(a));
        }
    }
}
