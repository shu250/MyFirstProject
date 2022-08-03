using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._20Jul
{
    class PrintTable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num + " is Table:");
            int i;
            for(i=1;i<=10;i++)
            {
                Console.WriteLine(num * i);
            }
        }
    }
}
