using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Practice
{
    class Array
    {
        public static void Show(int[]a,int n)
        {
            int s = n; 
            int n1 = n;
            while (n > 0)
            {
                bool isPrsent = false;

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == n)
                    {
                        s = a[i];
                        isPrsent = true;
                        break;
                    }
                }
                if (isPrsent == true)
                {
                    break;
                }
                n--;
            }
            Console.WriteLine(s);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Search Element:");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[5] { 3, 5, 10, 25, 30 };
            Show(a, n);
        }
    }
}
