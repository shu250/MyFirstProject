using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._12Aug
{
    class Frequency
    {
        public static int Count(int[] a,int  n)
        {
            int c = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] == n)
                {
                    c++;
                }
            }
            return c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int s = int.Parse(Console.ReadLine());
            int[] a = new int[s];
            Console.WriteLine("Enter Search Element:");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter Array Element:");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Frequency {n} is "+Frequency.Count(a,n));
        }
    }
}
