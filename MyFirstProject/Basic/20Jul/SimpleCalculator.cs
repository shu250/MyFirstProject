using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._20Jul
{
    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Choice:\n+ Addition\n- Substraction\n * Multiplication\n/ Division");
            char ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case '+':Console.WriteLine("Addition:" + (num1 + num2));
                    break;
                case '-':Console.WriteLine("Substraction:" + (num1 - num2));
                    break;
                case '*':Console.WriteLine("Multiplication:" + (num1 * num2));
                    break;
                case '/':Console.WriteLine("Division:" + (num1 / num2));
                    break;
                default:Console.WriteLine("Invalid Input.");
                    break;



            }
        }
    }
}
