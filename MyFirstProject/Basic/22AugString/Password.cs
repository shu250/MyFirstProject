using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._22AugString
{
    class Password
    {
        public static void Pass(string s)
        {
            if (s.Length >= 8)
            {
                int u = 0, l = 0, d = 0,sp=0;
                for(int c = 0; c < s.Length; c++)
                {
                    if (char.IsDigit(s[c]))
                    {
                        d++;
                    }
                    else if (char.IsLower(s[c]))
                    {
                        l++;
                    }
                    else if (char.IsUpper(s[c]))
                    {
                        u++;
                    }
                    else if (!char.IsLetterOrDigit(s[c]))
                    {
                        sp++;
                    }
                }
                //Console.WriteLine(d+" "+l+" "+u);
                if (d >= 1 && l >= 1 && u >= 1&&sp>=1)
                {
                    Console.WriteLine("Valid PassWord");
                }
                else
                {
                    Console.WriteLine("Invalid PassWord");
                }
            }
            else
            {
                Console.WriteLine("Not valid Password.");
            }
        }
        static void Main(string[] args)
        {
          
            Console.WriteLine("Enter password:");
            string s = Console.ReadLine();
            Pass(s);
        }
    }
}
