using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test4
{
    class _3
    {
        public static void Count(char[] a)
        {
            int a1 = 10;
            char ch = ' ';
            for (int i = 0; i < a.Length; i++)
            {
                 ch = a[i];
                int c = 1,min=a.Length;
                bool isPresent = true;
                for (int k = i-1; k >= 0; k--)
                {
                    if (a[i] == a[k])
                    {
                        isPresent = false;
                        break;
                    }
                }
                if (isPresent == true)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            c++;
                        }
                        if (min >=c)
                        {
                            min = c;
                            ch = a[i];
                        }
                    }
                    
                }
               
            }
            Console.WriteLine("Minimum Frequency is:" +ch);
        }
         static void Main(string[] args)
         {
                Console.WriteLine("Enter Array Size:");
                int s = int.Parse(Console.ReadLine());
                char[] a = new char[s];
                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine("Enter Array:");
                    a[i] = char.Parse(Console.ReadLine());
                }
                Count(a);
         }
        
    }
}
