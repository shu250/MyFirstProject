using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._22AugString
{
    class Email
    {
        public static void Validate(string s)
        {
            int a = s.IndexOf('@');
            int b = s.LastIndexOf('.');
            Console.WriteLine(a+" "+b);
            if (a > 1 && b > 2 && a < b)
            {
                Console.WriteLine("Valid Email");
            }
            else
            {
                Console.WriteLine("Invalid Email");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Email Id:");
            string s = Console.ReadLine();
            Validate(s);
        }
    }
}
