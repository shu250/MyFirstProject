using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._8Aug
{
    class SumOfArray
    {
        public int SumA(int[] a)
        {
           int Sum = 0;
            foreach(int d in a)
            {
                Sum = Sum + d;
            }
            return Sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int s = int.Parse(Console.ReadLine());
            int[] a = new int[s];
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter Number:");
                a[i] = int.Parse(Console.ReadLine());

            }
            SumOfArray z = new SumOfArray();
            int b = z.SumA(a);
            Console.WriteLine("Sumof Array:"+b);
        }

    }
}
