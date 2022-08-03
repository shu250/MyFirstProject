using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._21Jul.class1
{
    class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = int.Parse(Console.ReadLine());
            int i = 1,c=0;
            while (i <= num)
            {
                if (num % i == 0)
                {
                    c++;
                }
                i++;
            }
            if (c == 2)
            {
                Console.WriteLine(num + " is Prime Number.");
            }
            else
            {
                Console.WriteLine(num + " is not Prime Number.");
            }
        }
    }
}
