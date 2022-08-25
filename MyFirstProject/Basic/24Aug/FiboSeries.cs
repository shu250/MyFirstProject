using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._24Aug
{
    class FiboSeries
    {
        public static void Fibo(int n)
        {
            int a = 0, b = 1, s = 0;
            for(int i = 1; i <= n; i++)
            {
                Console.Write(s+" ");
                int t = s;
               
                a = b;
                b = t;
                s = a + b;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many series Element Print:");
            int n = int.Parse(Console.ReadLine());
            Fibo(n);
        }
    }
}
