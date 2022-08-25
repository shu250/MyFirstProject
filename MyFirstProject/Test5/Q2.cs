using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test5
{
    class Q2
    {
        public static void Swap(int[] a)
        {
            for(int i = 0; i < 2; i++)
            {
                int b = a[i];
                a[i] = a[a.Length - i - 1];
                a[a.Length - i - 1] = b;
            }
            Console.WriteLine(string.Join(" ",a));
        }

        static void Main(string[] args)
        {
            int[] a = new int[10];
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter Array Element:");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(string.Join(" ",a));
            Console.WriteLine("-----------------------------------");
            Swap(a);
            
        }
    }
}
