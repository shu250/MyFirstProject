using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.MyExamo.Ass2
{
    class Prime
    {
        static void Main(string[] args)
        {
            for(int i = 400; i >= 300; i--)
            {
                bool isPrime = true;
                for(int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime == true)
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}
