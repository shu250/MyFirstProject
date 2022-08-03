using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test2
{
    class _5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many Term Print:");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i<= n; i++)
            {
                Console.Write((i*i)-1+",");
            }
        }
    }
}
