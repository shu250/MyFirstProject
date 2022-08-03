using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._26Jul
{
    class Demo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 15 digit Number:");
            double num = double.Parse(Console.ReadLine());
            double sum = 0;
            while (num > 0)
            {
                sum = sum + num % 10;
                num = num / 10;
            }
            if (sum % 10 == 0)
            {
                Console.WriteLine("IMEI Number");
            }
            else
            {
                Console.WriteLine("No IMEI Number");
            }
        }
    }
}
