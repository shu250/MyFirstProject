using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._22AugString
{
    class Vowel
    {
        public static void Count(string s)
        {
            s = s.ToLower();
            int v = 0, c = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if(s[i]=='a'||s[i]=='e' || s[i] == 'o' || s[i] == 'u' || s[i] == 'i')
                {
                    v++;
                }
                else
                {
                    c++;
                }
            }
            Console.WriteLine("Vowel:"+v);
            Console.WriteLine("Consonent"+c);
            for(int i = s.Length-1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            string s = Console.ReadLine();
            Count(s);
        }
    }
}
