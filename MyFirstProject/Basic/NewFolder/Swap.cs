using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic.NewFolder
{
    class Swap
    {
        public static void Main(string[] args)
        {
            int num1 = 50;
            int num2 = 20;
            Console.WriteLine("Before Sorting" + "num1=" + num1+" " + "num2="+" " + num2);
           int num = num1+num2;
            num1 = num - num1;
            num2 = num - num2;
            Console.WriteLine("After Sorting" + "num1="+" " + num1 + "num2="+" " + num2);
        }

    }
}
