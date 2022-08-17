using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._16Aug2DArray
{
    class SumofRow
    {
        public static void Sum(int[,] a)
        {
            for(int i = 0; i < a.GetLength(0); i++)
            {
                int sum = 0;
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    sum = sum + a[i, j];
                    Console.Write(a[i,j]+" ");
                }
                Console.Write("Sum="+sum);
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] a = new int[3, 3] { { 2, 3, 4 }, { 3, 6, 7 }, { 9, 4, 12 } };
            Sum(a);
        }
    }
}
