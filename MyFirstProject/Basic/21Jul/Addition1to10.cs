using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._21Jul
{
    class Addition1to10
    {
        static void Main(string[] args)
        {
            int sum = 0, i = 1;
            while(i<=10)
            {
                sum = sum + i;
                i++;
            }
            Console.WriteLine("Sum of 1 to 10 Between:" + sum);
        }
    }
}
