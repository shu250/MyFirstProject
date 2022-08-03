using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._21Jul
{
    class AverageOfDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int c = 0;
            while (num > 0)
            {
                int n = num % 10;
                sum = sum + n;
                num = num / 10;
                c++;

            }
            Console.WriteLine("Sum of Digit="+sum);
            int avg = sum / c;
            Console.WriteLine("Average="+avg);
        }
    }
}
