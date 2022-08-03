using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._22Jul
{
    class Pattern5
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= 4; j++)
                {
                    if (j == 1 || i == j || j == 4)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
