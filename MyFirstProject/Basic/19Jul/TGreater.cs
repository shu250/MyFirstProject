using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._19Jul
{
    class TGreater
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            int num2 = int.Parse(Console.ReadLine());
            string result=num1>num2?num1+" is Greater":num2+" is Greater";
            Console.WriteLine(result);
        }
    }
}
