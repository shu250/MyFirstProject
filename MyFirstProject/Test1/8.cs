using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test1
{
    class _8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = int.Parse(Console.ReadLine());
            int num1 = num;
            int sum = 0,r;
            while (num > 0)
            {
                int fact = 1;
                r = num % 10;
                for(int i = 1; i <= r; i++)
                {
                    fact = fact* i;
                }
                sum = sum + fact;
                num = num / 10;
            }
            Console.WriteLine(sum);
            if (num1 == sum)
            {
                Console.WriteLine("Number is KrishnaMurthy");
            }
            else
            {
                Console.WriteLine("Number is Not KrishnaMurthy");
            }
        }
    }
}
