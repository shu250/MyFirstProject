using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test2
{
    class _4P
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many Print Row:");
            int r = int.Parse(Console.ReadLine());

            for(int i = 1; i<=r; i++)
            {
                for(int j = 1; j <=r+1-i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write(0);
                    }
                    else
                    {
                        Console.Write(1);
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
