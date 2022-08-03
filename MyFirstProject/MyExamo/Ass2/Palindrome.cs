using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.MyExamo.Ass2
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num1 = int.Parse(Console.ReadLine());
            int num = num1;
            int num2 = 0;
            while(num1!=0)
            {
                int n = num1 % 10;
                num2 = num2 * 10 + n;
                num1 = num1 / 10;

            }
            if (num == num2)
            {
                Console.WriteLine("is Palindrom");
            }
            else
            {
                Console.WriteLine(" Not Palindrom");
            }
        }
    }
}
