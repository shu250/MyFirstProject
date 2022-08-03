using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._19Jul
{
    class Vowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Character:");
            char ch = Convert.ToChar(Console.ReadLine());
            if(ch=='a' || ch=='e' || ch=='i' || ch=='o' || ch=='u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonent");
            }
        }
    }
}
