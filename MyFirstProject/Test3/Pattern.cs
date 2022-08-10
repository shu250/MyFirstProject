using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test3
{
    class Pattern
    {
        public void DrowP(int r)
        { int c = 0;
            for(int i = 1; i <= r; i++)
            {
                for(int k = 1; k <= r+1 - i; k++)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j <= i + c; j++)
                {
                    Console.Write(j);
                }
                c++;
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Pattern p = new Pattern();
            Console.WriteLine("How Many Row Print:");
            int r = int.Parse(Console.ReadLine());
            p.DrowP(r);
        }
    }
}
