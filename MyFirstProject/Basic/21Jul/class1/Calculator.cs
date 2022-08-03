using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._21Jul.class1
{
    class Calculator
    {
        static void Main(string[] args)
        {
            char c;
            do
            {
                Console.WriteLine("Enter First Number:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number:");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("1.Add\n2.Sub\n3.Mul\n4.Div");
                Console.WriteLine("Enter Your Choice:");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Addition=" + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("Substraction=" + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("Multiplication=" + (num1 * num2));
                        break;
                    case 4:
                        Console.WriteLine("Division=" + (num1 / num2));
                        break;
                    default:
                        Console.WriteLine("Invalid Input.");
                        break;

                }
                Console.WriteLine("Do you Want to Again Calculation? Y/N");
                c = Convert.ToChar(Console.ReadLine());
            } while (c == 'Y' || c == 'y');
        }
    }
}
