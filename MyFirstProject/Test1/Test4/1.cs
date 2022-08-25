using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test4
{
    class _1
    {
        public static void Count(int[] a)
        {
            int e = 0;
            int o = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    e++;
                }
                else
                {
                    o++;
                }
            }
            Console.WriteLine("Total even Number:"+e+" Total Odd Number:"+o);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Size:");
            int s = int.Parse(Console.ReadLine());
            int[] a = new int[s];
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter Element:");
                a[i] = int.Parse(Console.ReadLine());
            }
            Count(a);
        }
    }
}
