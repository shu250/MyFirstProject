using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._22AugString
{
    class Toggle
    {
        public static void T(string s)
        {
            string s1 = "";
            foreach(char c in s)
            {
                if (char.IsUpper(c))
                {
                    s1 = s1 + char.ToLower(c);
                }
                else if (char.IsLower(c))
                {
                    s1 = s1 + char.ToUpper(c);
                }
            }
            Console.WriteLine(s1);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            string s = Console.ReadLine();
            T(s);
        }
    }
}
