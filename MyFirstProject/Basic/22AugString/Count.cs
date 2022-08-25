using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._22AugString
{
    class Count
    {
        public static int Charter(string s,char c)
        {
            int n = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if (c == s[i])
                {
                    n++;
                }
            }
            return n;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string s = Console.ReadLine();
            Console.WriteLine("Enter Charter:");
            char c = char.Parse(Console.ReadLine());
            int a = Charter(s, c);
            Console.WriteLine(a);
        }
    }
}
