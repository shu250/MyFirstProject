using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._17AugPattern
{
    class UpperTringle
    {
        public static void UpperT(int[,] a)
        {
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    if (i <= j)
                    {
                        Console.Write(1+" ");
                    }
                    else
                    {
                        Console.Write(0+" ");
                    }

                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] a = new int[5, 5];

            UpperT(a);
        }
    }
}
