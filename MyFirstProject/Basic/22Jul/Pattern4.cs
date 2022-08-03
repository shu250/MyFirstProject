using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._22Jul
{
    class Pattern4
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= 5 - i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
