using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._22Jul
{
    class Pattern6
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 4; i++)
            {
                if (i % 2 == 0)
                {
                    char ch = 'A';
                    for (int j = 1; j <= i; j++)
                    {
                  
                        Console.Write(ch);
                        ch++;
                    }
                    Console.WriteLine();
                }
                
                else
                {
                    for(int j = 1; j <= i; j++)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();
                }

            }
            
        }
    }
}
