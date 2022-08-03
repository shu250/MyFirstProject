using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test2
{
    class _3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int n = int.Parse(Console.ReadLine());

            int s = n * n;
            int x=0,y=0;
            if (s >= 100&&s<1000)
            {
                int n1 = s % 10;
                int n2 = s / 10;
                int s1 = n1 + n2;
                x = s1;
                int n3 = s % 100;
                int n4 = s / 100;
                int s2 = n3 + n4;
                y = s2;

            }
            else if (s>=1000)
            {
                int n1 = s % 1000;
                int n2 = s / 1000;
                int s1 = n1 + n2;
            
                x=s1;
                int n3 = s % 100;
                int n4 = s / 100;
                int s2 = n3 + n4;
                y = s2;
              
            }
            if (n == x || n == y)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
