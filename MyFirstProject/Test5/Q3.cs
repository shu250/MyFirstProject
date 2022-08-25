using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test5
{
    class Q3
    {
        public static void Frequncy(int[] a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                int c = 0;
                bool isPrsent = false;
                for(int j = i - 1; j >= 0; j--)
                {
                    if (a[i] == a[j])
                    {
                        isPrsent = true;
                        break;
                    }
                }
                if (isPrsent == false)
                {
                    for(int k = i; k < a.Length; k++)
                    {
                        if (a[i] == a[k])
                        {
                            c++;
                        }
                    }
                    Console.WriteLine(a[i] + " " + c);
                }
                
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Size:");
            int s = int.Parse(Console.ReadLine());
            int[] a = new int[s];
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter Array Element:");
                a[i] = int.Parse(Console.ReadLine());
            }
            Frequncy(a);
        }
    }
}
