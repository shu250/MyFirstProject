using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._18june
{
    class Alphabet
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter :");
            char ch = Convert.ToChar(Console.ReadLine());
            if(ch>='a' && ch<='z')
            {
                Console.WriteLine(ch + " is alphabet.");
            }
            else if(ch>='A' && ch<='Z')
            {
                Console.WriteLine(ch + " is alphabet.");
            }
            else if(ch>='0' && ch<='9')
            {
                Console.WriteLine(ch + " is Digit");
            }
            else
            {
                Console.WriteLine(ch + " is Symbol");
            }
        }

    }
}
