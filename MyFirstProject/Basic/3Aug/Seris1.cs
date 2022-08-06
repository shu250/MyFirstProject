using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._3Aug
{
    class Seris1
    {
        public void Series(int n)
        {
            int a = 1;
            for (int i = 1; i <= n; i++)
            {
               
                Console.Write(a+" ");
                a = a * 2 + 1;
            }
        }
        public void Series1(int n)
        {
            int a = 2;
            for (int i = 1; i <= n; i++)
            {

                Console.Write(a + " ");
                a = a * 2 -1;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int n = int.Parse(Console.ReadLine());
            Seris1 s = new Seris1();
            s.Series(n);
            Console.WriteLine();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Enter Number:");
            int n1 = int.Parse(Console.ReadLine());
            s.Series1(n1);
        }
    }
}
