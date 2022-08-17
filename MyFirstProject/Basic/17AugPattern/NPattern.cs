using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._17AugPattern
{
    class NPattern
    {
        public static void N(char[,] a)
        {
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    if (j == 0 || j == a.GetUpperBound(1) || i == j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            char[,] a = new char[6,6];
            N(a);
        }
    }
}
