using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._24Aug
{
    class CoPrime
    {
        public static void Cprime(int n1,int n2)
        {
            int c = 0;
            int max = n1;
            if(n1 < n2)
            {
                max = n2;
            }
            for(int i = 1; i < max; i++)
            {
                if (n2 % i == 0 && n1 % i == 0)
                {
                    c++;
                }
            }
            if (c == 1)
            {
                Console.WriteLine("CoPrime");
            }
            else
            {
                Console.WriteLine("Not CoPrime");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            int n2 = int.Parse(Console.ReadLine());
            Cprime(n1, n2);
        }
    }
}
