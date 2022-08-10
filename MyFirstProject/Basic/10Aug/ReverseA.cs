using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._10Aug
{
    class ReverseA
    {
        public void Reverse(int[] a)
        {
            int l = a.Length - 1;

            for(int i = 0; i < (a.Length / 2); i++)
            {
                int z = a[i];
                a[i] = a[l];
                a[l] = z;
                l--;

            }
            Console.WriteLine("------------------------------");
            Console.WriteLine(string.Join(" ",a));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Size:");
            int s = int.Parse(Console.ReadLine());
            int[] a = new int[s];
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter Array Element:");
                a[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine(string.Join(" ", a));
            ReverseA r = new ReverseA();
            r.Reverse(a);
        }
    }
}
