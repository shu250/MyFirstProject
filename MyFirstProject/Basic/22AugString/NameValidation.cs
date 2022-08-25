using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._22AugString
{
    class NameValidation
    {
        public static void Name(string s)
        {
            bool isName = true;
            foreach(char c in s)
            {
                if (char.IsDigit(c))
                {
                    isName = false;
                    break;
                }
                else if (char.IsSymbol(c))
                {
                    isName = false;
                    break;
                }
            }
            if (isName == true)
            {
                Console.WriteLine("Name is valid");
            }
            else
            {
                Console.WriteLine("Name is not Valid");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string s = Console.ReadLine();
            Name(s);
        }
    }
}
