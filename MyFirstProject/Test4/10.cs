using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test4
{
    class _10
    {
        public static void Square(int[] a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                for(int j = 1; j <= a[i] / 2; j++)
                {
                    if (a[i] == (j * j))
                    {
                        Console.Write(a[i]+" ");
                    }
                    
                }
                if (a[i] == 1)
                {
                    Console.Write(a[i] + " ");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array size:");
            int s = int.Parse(Console.ReadLine());
            int[] a = new int[s];
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter Array Element:");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("------------------------------");
            Square(a);
        }
    }
}
