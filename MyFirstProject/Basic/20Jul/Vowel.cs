using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._20Jul
{
    class Vowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Character:");
            char ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case 'a':Console.WriteLine("Vowel");
                    break;
                case 'e':Console.WriteLine("Vowel");
                    break;
                case 'i':Console.WriteLine("Vowel");
                    break;
                case 'o':Console.WriteLine("Vowel");
                    break;
                case 'u':Console.WriteLine("Vowel");
                    break;
                case 'A':Console.WriteLine("Vowel");
                    break;
                case 'E':Console.WriteLine("Vovel");
                    break;
                case 'I':Console.WriteLine("Vowel");
                    break;
                case 'O':Console.WriteLine("Vowel");
                    break;
                case 'U':Console.WriteLine("Vowel");
                    break;
                default:Console.WriteLine("Consonent");
                    break;

            }
        }
    }
}
