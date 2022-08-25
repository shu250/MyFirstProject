using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._23Aug
{
    class Frequency
    {
        public static void Count(string s)
        {
            
            char []a=s.ToCharArray();
            //Console.WriteLine(a);
            for(int i = 0; i < a.Length; i++)
            {
                
                bool isPresent = false;
                for(int j = i - 1; j >= 0; j--)
                {
                    if (a[i] == a[j])
                    {
                        isPresent = true;
                        break;
                    }
                }
                int c = 1;
                if (isPresent == false)
                {
                    for(int k = i + 1; k < a.Length; k++)
                    {
                        if (a[k] == a[i])
                        {
                            c++;
                        }
                    }
                    Console.WriteLine(a[i]+" "+c);
                }
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
