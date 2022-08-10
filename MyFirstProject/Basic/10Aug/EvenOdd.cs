using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._10Aug
{
    class EvenOdd
    {
        public static void OddE(int[] a)
        {
           int[] ae = new int[a.Length];
           int[] ao = new int[a.Length];
            int j = 0, k = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    ae[j] = a[i];
                    j++;
                }
                else
                {
                    ao[k] = a[i];
                    k++;
                }
            }
            Console.WriteLine("Even Number:");
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine(ae[i]+" ");
            }
            Console.WriteLine("\nOdd Number");
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(ao[i] + " ");
            }
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
            EvenOdd.OddE(a);
            
        }
    }
}
