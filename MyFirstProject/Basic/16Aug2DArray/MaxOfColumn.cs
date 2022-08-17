using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._16Aug2DArray
{
    class MaxOfColumn
    {
        public static void MaxC(int[,] a)
        {
            for(int i = 0; i < a.GetLength(0); i++)
            {
                int max = a[0, i];
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    if (max < a[j, i])
                    {
                        max = a[j, i];
                    }
                    Console.WriteLine(a[j,i]);
                }
                Console.WriteLine("Max="+max);
                Console.WriteLine("---------------------");
            }
        }

        static void Main(string[] args)
        {
            int[,] a = new int[3, 3] { { 1, 2, 3 }, { 5, 4, 9 }, { 7, 5, 6 } };
            MaxC(a);
        }
    }
}
