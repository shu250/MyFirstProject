using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test4
{
    class _6
    {
        public static int[] Zero(int[] a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                for(int j = 0; j < a.Length -1; j++)
                {
                    if (a[j] == 0)
                    {
                        a[j] = a[j + 1];
                        a[j + 1] = 0;
                    }
                }
            }
            return a;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Size:");
            int s = int.Parse(Console.ReadLine());
            int[] a = new int[s];
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter Array Size");
                a[i] = int.Parse(Console.ReadLine());
            }
            int[] b = _6.Zero(a);
            Console.WriteLine(string.Join(" ",a));
        }
    }
}
