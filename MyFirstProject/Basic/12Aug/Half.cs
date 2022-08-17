using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._12Aug
{
    class Half
    {
        public static int[] HalfSort(int[] a)
        {
            for(int i = 0; i < (a.Length / 2); i++)
            {
                for(int j = i+1; j < (a.Length / 2); j++)
                {
                    if (a[i] >a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
               
            }
            for (int i = (a.Length / 2); i < a.Length; i++)
            {
                for (int j = (a.Length / 2); j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
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
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ",a));
            Console.WriteLine("-------------------------------");
            int[] b = Half.HalfSort(a);
            Console.WriteLine(string.Join(" ",b));
        }
    }
}
