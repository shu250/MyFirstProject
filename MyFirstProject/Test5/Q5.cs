using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test5
{
    class Q5
    {
        public static void Zero(int[] a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                for(int j = 0; j < a.Length-1; j++)
                {
                    if (a[j] == 0)
                    {
                        a[j] = a[j + 1];
                        a[j + 1] = 0;
                    }
                }
            }
            Console.WriteLine(string.Join(" ",a));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array size:");
            int s = int.Parse(Console.ReadLine());
            int[] a = new int[s];
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter Array Element:");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ",a));
            Console.WriteLine("-------------------------------");
            Zero(a);
        }
    }
}
