using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._17AugPattern
{
    class LowerTRingle
    {
        public static void LowerT(int[,] a)
        {
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    if (i >= j)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] a = new int[5,5];
            LowerT(a);
        }
    }
}
