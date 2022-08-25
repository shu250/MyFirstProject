using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._17AugPattern
{
    class SparseA
    {
        public static bool Sparse(int[,] a)
        {
            bool isSparse = true;
            int c = 0;
            int z = 0;
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] != 0)
                    {
                        c++;
                    }
                    else
                    {
                        z++;
                    }
                }
            }
            if (z < c)
            {
                isSparse = false;
            }
            return isSparse;
        }

        static void Main(string[] args)
        {
            int[,] a = new int[4, 4];
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine("Enter Array Element:");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
           bool s= Sparse(a);
            if (s==true)
            {
                Console.WriteLine("Sparse Matrix");
            }
            else
            {
                Console.WriteLine("Not Sparse Matrix");
            }
        }
    }
}
