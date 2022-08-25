using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._23Aug
{
    class RemoveDuplicate
    {

        public static void Duplicate(string s)
        {
            string s1 = "";
            foreach(char ch in s)
            {
                if (!s1.Contains(ch))
                {
                    s1 = s1 + ch;
                }
            }
            Console.WriteLine(s1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            string s = Console.ReadLine();
            Duplicate(s);
        }
    }
}
