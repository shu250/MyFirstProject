using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._3Aug
{
   
    class Palindrome
    {
        public void PNumber(int n)
        {
            int temp = n;
            int sum = 0;
            while (n > 0)
            {
                sum = sum * 10 + n % 10;
                n = n / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome.");
            }
        }
        static void Main(string[] args)
        {
            Palindrome p = new Palindrome();
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Enter Number:");
                int n = int.Parse(Console.ReadLine());
                if (n > 0)
                {
                    p.PNumber(n);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
