using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._10Aug
{
    class MergeArray
    {
        public void Merge(int[] a,int[] a1)
        {
            int[] a2 = new int[a.Length + a1.Length];
            for(int i = 0; i < a.Length; i++)
            {
                a2[i] = a[i];
            }
            int l = a.Length;
            for(int i = 0; i < a1.Length; i++)
            {
                bool isNum = false;
                for(int j = 0; j < a.Length; j++)
                {
                    if (a1[i] == a[i])
                    {
                        isNum = true;
                    }
                }
                if (isNum == false)
                {
                    a2[l] = a1[i];
                    l++;
                }
            }
            Console.WriteLine(string.Join(" ",a2));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First array size:");
            int s = int.Parse(Console.ReadLine());
            int[] a = new int[s];
            Console.WriteLine("Enter Second Array Size:");
            int s1 = int.Parse(Console.ReadLine());
            int[] a1 = new int[s1];
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter First Array Element:");
                a[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < a1.Length; i++)
            {
                Console.WriteLine("Enter Second Array Element:");
                a1[i] = int.Parse(Console.ReadLine());
            }
            MergeArray m = new MergeArray();
            m.Merge(a, a1);
        }
    }
}
