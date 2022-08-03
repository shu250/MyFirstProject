using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._20Jul
{
    class DSimpleCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Choice:\n1.Addition\n2.Substraction\n3.Multiplication\n4.Division");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:Console.WriteLine("Addition"+(num1 + num2));
                    break;
                case 2:Console.WriteLine("Substraction"+(num1 - num2));
                    break;
                case 3:Console.WriteLine("Multiplication:"+(num1*num2));
                    break;
                case 4:Console.WriteLine("Substraction:"+(num1/num2));
                    break;
                default:Console.WriteLine("Invalid Input.");
                    break;

            }
        }
    }
}
