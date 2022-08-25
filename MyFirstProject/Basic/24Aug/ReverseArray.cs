using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._24Aug
{
    class ReverseArray
    {
        public static void Reverse(int[] a)
        {
            int j = a.Length - 1;
            for(int i = 0; i < a.Length / 2; i++)
            {
                int k = a[i];
                a[i] = a[j];
                a[j] = k;
                j--;
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
            Console.WriteLine("--------------------------");
            Reverse(a);
        }
    }
}
