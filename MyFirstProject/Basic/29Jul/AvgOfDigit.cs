using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._29Jul
{
    class AvgOfDigit
    {
        public int Average(int n)
        {
            int c = 0, sum = 0;
            while (n > 0)
            {
                sum = sum + n % 10;
                c++;
                n = n / 10;
            }
          
            return sum / c;
        }

        static void Main(string[] args)
        {
            AvgOfDigit a = new AvgOfDigit();
            Console.WriteLine("Enter Number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Average of Digit:"+a.Average(num));
        }
    }
}
