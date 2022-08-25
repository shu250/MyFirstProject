using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test5
{
    class Q1
    {
        public static void MergA(int[] a1, int[] a2)
        {
            int j = 0,k=0;
            int[]a3 = new int[a1.Length + a2.Length];
            for(int i = 0; i < a1.Length; i++)
            {
                if (a3.Length * 2 - 1 >= a3[i + j])
                {
                    a3[i + j] = a1[i];
                    j++;
                    k = i + j;
                }
                else
                {
                    a3[k] = a1[i];
                }
            }
            /*for(int i = 0; i < a2.Length; i++)
            {
                if (a1.Length <= i)
                {
                    ++k;
                    a3[k] = a2[i];
                }
                else
                {

                    a3[k + i] = a2[i];
                }
                k++;
            }*/
            Console.WriteLine(string.Join(" ",a3));
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter first Array Size:");
            int s1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second Array Size");
            int s2 = int.Parse(Console.ReadLine());
            int[] a1 = new int[s1];
            int[] a2 = new int[s2];
            for(int i = 0; i < a1.Length; i++)
            {
                Console.WriteLine("enter First Array Element:");
                a1[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < a2.Length; i++)
            {
                Console.WriteLine("enter second Array Element:");
                a2[i] = int.Parse(Console.ReadLine());

            }
            MergA(a1, a2);
        }
    }
}
