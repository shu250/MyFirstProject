using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._12Aug
{
    class Merge
    {
        public static int[] MergeArray(int[] a,int[] a1,int[] a2)
        {
            int m = 0;
            for(int i = 0; i < a.Length; i++)
            {
                bool isNum = false;
                for(int k = m - 1; k >= 0; k--)
                {
                    if (a2[k] == a[i])
                    {
                        isNum = true;
                        break;
                    }
                }
                if (isNum == false)
                {
                    a2[i] = a[i];
                    m++;
                }
            }
            for (int i = 0; i < a1.Length; i++)
            {
                bool isNum = false;
                for (int k = m - 1; k >= 0; k--)
                {
                    if (a2[k] == a1[i])
                    {
                        isNum = true;
                        break;
                    }
                }
                if (isNum == false)
                {
                    a2[i] = a1[i];
                    m++;
                }
            }
            return a2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Array Size:");
            int s = int.Parse(Console.ReadLine());
            int[] a = new int[s];
            Console.WriteLine("Enter Second Array Size:");
            int s1 = int.Parse(Console.ReadLine());
            int[] a1 = new int[s1];
            int[] a2 = new int[a.Length + a1.Length];
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter First Array Element.");
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a1.Length; i++)
            {
                Console.WriteLine("Enter Second Array Element.");
                a1[i] = int.Parse(Console.ReadLine());
            }
            int[] b = Merge.MergeArray(a, a1,a2);
            Console.WriteLine(string.Join(" ",b));
        }
        
    }
}
