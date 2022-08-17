using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._16Aug2DArray
{
    class SumOfColumn
    {
        public static void SumC(int[,] a)
        {
            for(int i = 0; i < a.GetLength(0); i++)
            {
                int sum = 0;
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    sum = sum + a[j, i];
                }
                Console.WriteLine("Column Sum:"+sum);
            }
        }
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3];
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
                    Console.Write(a[i,j]+" ");
                 
                }
                Console.WriteLine();
            }
            SumC(a);
        }
    }
}
