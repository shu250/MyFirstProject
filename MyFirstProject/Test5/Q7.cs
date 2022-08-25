using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test5
{
    class Q7
    {
        public static void Maximum(int[,] a)
        {
            for(int i = 0; i < a.GetLength(0); i++)
            {
                int max = a[i, 0];
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                    }
                }
                Console.WriteLine(i+" row max Element "+max);
            }
        }
        static void Main(string[] args)
        {
            int[,] a = new int[2, 3];
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine("Enter Array Element:");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Maximum(a);
        }
    }
}
