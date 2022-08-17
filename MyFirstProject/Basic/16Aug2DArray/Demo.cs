using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._16Aug2DArray
{
    class Demo
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3 }, { 8, 6, 5 } };
            int[,] a1 = new int[2, 3];
            a1[0, 0] = 1;
            a1[0, 1] = 3;
            a1[0, 2] = 4;
            a1[1, 0] = 4;
            a1[1, 1] = 5;
            a1[1, 2] = 7;
            int[,] a2 = new int[2, 2];
            for(int i = 0; i < a2.GetLength(0); i++)
            {
                for(int j = 0; j < a2.GetLength(1); j++)
                {
                    Console.WriteLine("Enter Element:");
                    a2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("--------------------------------");
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------");
            for(int i = 0; i <= a1.GetUpperBound(0); i++)
            {
                for(int j = 0; j <= a1.GetUpperBound(1);j++)
                {
                    Console.Write(a1[i,j]+" ");
                }
                Console.WriteLine();
            }
            for(int i = 0; i < a2.GetLength(0); i++)
            {
                for(int j = 0; j < a2.GetLength(1); j++)
                {
                    Console.Write(a2[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
