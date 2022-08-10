using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._10Aug
{
    class NegativeReplace
    {
        public static void NReplace(int[] a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    a[i] = a[i - 1] * a[i - 1];
                }
            }
            Console.WriteLine(string.Join(" ",a));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int s = int.Parse(Console.ReadLine());
            int[] a = new int[s];
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter Array Element:");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ",a));
            Console.WriteLine("------------------------");
            NegativeReplace.NReplace(a);
        }
    }
}
