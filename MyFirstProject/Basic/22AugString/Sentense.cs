using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._22AugString
{
    class Sentense
    {
        public static string Rverse(string s)
        {
            string s1 = "";
            for(int i = s.Length - 1; i >= 0; i--)
            {
                s1 = s1 + s[i];
            }
            return s1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Sentense:");
            string s = Console.ReadLine();
            string[] a = s.Split(" ");
            string s2 = "";
            foreach(string z in a)
            {

                s2=s2+Rverse(z)+" "; 
            }
            Console.WriteLine(s2);
        }
    }
}
