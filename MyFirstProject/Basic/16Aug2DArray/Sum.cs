using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._16Aug2DArray
{
    class Sum
    {
        public static void Addition(int[,] a, int[,] a1, int[,] s)
        {
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    int sum = a[i, j] + a1[i, j];
                    s[i,j] = sum;
                }
            }
            for(int i = 0; i < s.GetLength(0); i++)
            {
                for(int j = 0; j < s.GetLength(1); j++)
                {
                    Console.Write(s[i,j]+" ");
                }
            }
        }
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];
            int[,] a1 = new int[2, 2];
            int[,] s = new int[2, 2];
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine("Enter first array element:");
                    a[i, j] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second array element:");
                    a1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Addition(a, a1, s);
        }
    }
}
