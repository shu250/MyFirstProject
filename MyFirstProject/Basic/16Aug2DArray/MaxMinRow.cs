using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._16Aug2DArray
{
    class MaxMinRow
    {
        public static void Min(int[,] a)
        {
            for(int i = 0; i < a.GetLength(0); i++)
            {
                int m = a[i, 0];
                int max = a[i, 0];
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    if(m>a[i,j])
                    {
                        m = a[i, j];
                    }
                    if (max < a[i, j])
                    {
                        max = a[i, j];
                    }
                    Console.Write(a[i,j]+" ");
                }
                Console.Write("Max="+max+" MIn="+m);
                Console.WriteLine();
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
            Min(a);
        }

    }
}
