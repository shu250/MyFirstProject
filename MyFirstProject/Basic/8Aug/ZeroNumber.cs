using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._8Aug
{
    class ZeroNumber
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter Number");
                int n = int.Parse(Console.ReadLine());
                bool isZero = false;
                while (n > 0)
                {
                    if (n % 10 == 0)
                    {
                        isZero = true;
                        
                    }
                    n = n / 10;
                }
                if (isZero == true)
                {
                    break;
                }
            }
        }
    }
}
