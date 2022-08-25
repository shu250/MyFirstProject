using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._23Aug
{
    class Anagram
    {
        public static void Ana(string s,string s1)
        {
            if (s.Length == s1.Length)
            {
                char[] a = s.ToCharArray();
                char[] b = s.ToCharArray();

                Array.Sort(a);
                Array.Sort(b);
                if (string.Join("",a)==string.Join("",b))
                {
                    Console.WriteLine("Anagram ");
                }
                else
                {
                    Console.WriteLine("Not AnaGram");
                }
            }
            else
            {
                Console.WriteLine("Not Anagram");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter First String:");
            string s = Console.ReadLine();
            Console.WriteLine("Enter Second String:");
            string s1 = Console.ReadLine();
            Ana(s, s1);

        }
    }
}
