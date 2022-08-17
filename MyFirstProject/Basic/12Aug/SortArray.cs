using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._12Aug
{
    class SortArray
    {
        public static int[] MySort(int[] a)
        {
            for(int i = 0; i <= a.Length; i++)
            {
                for(int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[j];
                        a[j] = a[i];
                        a[i] = temp;
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
            for (int i = 0; i <a.Length; i++)
            {
                Console.WriteLine("Enter Array Element:");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ",a));
            Console.WriteLine("----------------------------");
            int[] b = MySort(a);
            Console.WriteLine(string.Join(" ",a));
        }
    }
}
