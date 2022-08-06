using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._3Aug
{
    class Series2
    {
        public void PrintS(int n)
        {
            int a = 1;
            int b = 2;
            for(int i = 1; i <= n; i++)
            {
                Console.Write(a+" "+b+" ");
                a = a * 2 + 1;
                b = b * 2 - 1;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int n = int.Parse(Console.ReadLine());
            Series2 s = new Series2();
            s.PrintS(n);

        }
    }
}
