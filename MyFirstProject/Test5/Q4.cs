using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test5
{
    class Q4
    {
        public static void Negative(int[] a)
        {
            int c = 0;
            int[] a1 = new int[a.Length];
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    a1[c] = a[i];
                    c++;
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    a1[c] = a[i];
                    c++;
                }
            }
            Console.WriteLine(string.Join(" ",a));
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(string.Join(" ", a1));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Entter array size:");
            int s = int.Parse(Console.ReadLine());
            int[] a = new int[s];
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter Array Element:");
                a[i] = int.Parse(Console.ReadLine());
            }
            
            Negative(a);
        }
    }
}
