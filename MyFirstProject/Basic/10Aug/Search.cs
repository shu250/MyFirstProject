using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._10Aug
{
    class Search
    {
        public static bool SearchE(int[] a,int n)
        {
            bool isNum = false;
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] == n)
                {
                    isNum = true;
                    break;
                }
            }
            return isNum;
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
            Console.WriteLine("Enter Search Element:");
            int n = int.Parse(Console.ReadLine());
           bool b= Search.SearchE(a, n);
            if (b == true)
            {
                Console.WriteLine("Number is Found");
            }
            else
            {
                Console.WriteLine("Number Not Found");
            }

        }
    }
}
