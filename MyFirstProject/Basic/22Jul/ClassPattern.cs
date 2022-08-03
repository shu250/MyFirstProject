using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._22Jul
{
    class ClassPattern
    {
        static void Main(string[] args)
        {
            /* for(int i = 1; i <= 5; i++)
             {
                 for(int j=1;j<=6-i;j++)
                 {
                     Console.Write(i);
                 }
                 Console.WriteLine();*/

            /*for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine(); */


            /* for (int i = 1; i <= 5; i++)
             {
                 for (int j = 1; j <=i; j++)
                 {
                     if (j == 1 || i == 5 || i == j)
                     {
                         Console.Write("* ");
                     }
                     else
                     {
                         Console.Write("  ");
                     }
                 }
                 Console.WriteLine();
               }*/

            /*  for (char i = 'A'; i <= 'D'; i++)
              {
                  for (char j = 'A'; j <= i; j++)
                  {
                      Console.Write(i);
                  }
                  Console.WriteLine();

             
            } */

            /*int x = 1;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(x+" ");
                    x++;
                }
                Console.WriteLine();

            }*/

            /* for (int i = 1; i <= 5; i++)
             {
                 for (int j = 5; j >= i; j--)
                 {
                     Console.Write(" ");
                 }
                 for (int k = 1; k <= i; k++)
                 {
                     Console.Write("* ");
                 }
                 Console.WriteLine();
             }*/

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    if (i == 5 || k == 1 || i == k)
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
