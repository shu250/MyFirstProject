using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test3
{
    class Pattern
    {
        public void DrowP()
        { int c = 0;
            for(int i = 1; i <= 4; i++)
            {
                for(int k = 1; k <= 5 - i; k++)
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
            p.DrowP();
        }
    }
}
