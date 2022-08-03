using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._19Jul
{
    class TPositive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            string result = num > 0 ? num + " is Positive" : num + " is Negative";
            Console.WriteLine(result);
        }
    }
}
