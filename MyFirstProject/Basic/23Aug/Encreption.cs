using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._23Aug
{
    class Encreption
    {
        public static void Enc(string s,int n)
        {
            char[] a = s.ToCharArray();
            for(int i = 0; i < a.Length; i++)
            {
                if (char.IsUpper(a[i]))
                {


                    int k = 1;
                    char j = a[i];
                    while (k <= n)
                    {

                        //j = a[i];
                        j++;
                        if (!char.IsLetter(j))
                        {
                            j = 'A';
                        }
                        k++;
                    }
                    a[i] = j;
                }
                else
                {
                    int k = 1;
                    char j = a[i];
                    while (k <= n)
                    {

                        //j = a[i];
                        j++;
                        if (!char.IsLetterOrDigit(j))
                        {
                            j = 'a';
                        }
                        k++;
                    }
                    a[i] = j;
                }
            }
            Console.WriteLine(string.Join("",a));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            string s = Console.ReadLine();
            Console.WriteLine("Enter no of Digit Move:");
            int n = int.Parse(Console.ReadLine());
            Enc(s, n);
        }
    }
}
