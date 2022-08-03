using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.MyExamo.Ass1
{
    class Sum1and3Digit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = int.Parse(Console.ReadLine());
            int num1 = num;
            int c = 0, s = 0;
            
            while (num > 0)
            {
                c++;
                num = num / 10;
            }
            if (c == 3)
            {
                s = s + num1 % 10;
                num1 = num1 / 10;
                num1 = num1 / 10;
                s = s + num1 % 10;


            }
            Console.WriteLine(s);
        }
    }
}
