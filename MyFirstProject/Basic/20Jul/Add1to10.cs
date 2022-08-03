using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._20Jul
{
    class Add1to10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition of 1 to 10:");
            int i,sum=0;
            for (i = 1; i <= 10; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}
