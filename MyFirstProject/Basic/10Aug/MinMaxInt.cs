using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._10Aug
{
    class MinMaxInt
    {
        public static int Min(int[] a)
        {
            int MinN = a[0];
            for(int i = 0; i < a.Length; i++)
            {
                if (MinN > a[i])
                {
                    MinN = a[i];
                }
            }
            return MinN;
        }
        public static int Max(int[] a)
        {
            int MaxN = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (MaxN < a[i])
                {
                    MaxN = a[i];
                }
            }
            return MaxN;
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

            Console.WriteLine("Mininimum Value is:"+MinMaxInt.Min(a));
            Console.WriteLine("Maximum Value is:" + MinMaxInt.Max(a));

        }
    }
}
