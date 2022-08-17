using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test4
{
    class _7
    {
        public static void Duplicate(int[] a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                bool isPresent = false;
                for(int j = i-1; j >= 0; j--)
                {
                    if (a[i] == a[j])
                    {
                        isPresent = true;
                        break;
                    }
                }
                if (isPresent == true)
                {
                    a[i] = 0;
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0)
                {
                    Console.Write(a[i] + " ");
                }
            }
            //Console.WriteLine(string.Join(" ",a));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Size:");
            int s = int.Parse(Console.ReadLine());
            int[] a = new int[s];
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter Array Element");
                a[i] = int.Parse(Console.ReadLine());
            }
            _7.Duplicate(a);
        }
    }
}
