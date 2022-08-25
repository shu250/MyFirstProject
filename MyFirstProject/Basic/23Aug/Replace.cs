using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._23Aug
{
    class Replace
    {
        public static void Remove1(string s)
        {
            string s1 = "";
            char[] c = s.ToCharArray();

            for(int i=0;i<s.Length;i++)
            {

                if (c[i] == 'a' || c[i] == 'e' || c[i] == 'i' || c[i] == 'o' || c[i] == 'u')
                {
                    char j = c[i];
                    j++;
                    c[i] = j;

                }

            }
            Console.WriteLine(string.Join("",c));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            string s = Console.ReadLine();
            Remove1(s);

        }
    }
}
