using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._22AugString
{
    class Palindrome
    {
        public static string Revrse(string s)
        {
            s = s.ToLower();
            string s1 = "";
            for(int i = s.Length - 1; i >= 0; i--)
            {
                s1 = s1 + s[i];
            }
            return s1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            string s = Console.ReadLine();
            string s2 = Revrse(s);
            if (s == s2)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }
}
