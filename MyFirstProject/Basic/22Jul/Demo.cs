using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._22Jul
{
    class Demo
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= 6 - i; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                for(int l = 1; l < i; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
        }
    }
}
