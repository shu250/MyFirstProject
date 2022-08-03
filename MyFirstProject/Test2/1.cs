using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test2
{
    class _1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Mobile Number:");
            long mn = long.Parse(Console.ReadLine());

            /*Console.WriteLine("Enter Number to Find Frequency:");
            int n = int.Parse(Console.ReadLine());*/

            long mn2 = mn;
            
            while (mn > 0)
            {
                int c = 0;
                long mn1 = mn2;
                long t = mn % 10;
                while (mn1 > 0)
                {

                    long t1 = mn1 % 10;
                    if ( t== t1)
                    {
                        c++;
                    }
                    mn1 = mn1 / 10;
                }
                Console.WriteLine(t+"  Frequency is:  " + c);
                mn = mn / 10;
            }

        }
    }
}
