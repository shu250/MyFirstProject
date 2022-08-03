using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test2
{
    class _2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Base:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter index:");
            int y = int.Parse(Console.ReadLine());
            int p=1;
            while (y > 0)
            {
                p = p * x;
                y--;
            }
            Console.WriteLine(p);
        }
    }
}
