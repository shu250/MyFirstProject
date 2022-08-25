using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test5
{
    class Q6
    {
        public static void Reverse(int[,] a)
        {
            for(int i = 0; i < a.GetLength(0); i++)
            {
                int k = a.GetUpperBound(1);
                for(int j = 0; j < a.GetLength(1)/2; j++)
                {
                    int b = a[i, j];
                    a[i, j] = a[i, k];
                    a[i, k] = b;
                    k--;
                }
            }
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            
            int[,] a = new int[2,4];
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine("Enter Array Element:");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Reverse(a);
        }
    }
}
