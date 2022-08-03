using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._21Jul
{
    class CountOddNo
    {
        static void Main(string[] args)
        {
            int i = 1, c = 0;
            while (i <= 20)
            {
                if (i % 2 == 0)
                {
                    c++;
                }
                i++;
            }
            Console.WriteLine(c + " odd No. in between 1 to 20.");
        }
    }
}
