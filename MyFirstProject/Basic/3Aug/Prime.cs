using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._3Aug
{

    class Prime
    {
        public bool CheckP(int n)
        {
            bool isprime = true;
            for(int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isprime = false;
                    break;
                }
            }
            return isprime;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Prime p = new Prime();
                Console.WriteLine("Enter Number:");
                int n = int.Parse(Console.ReadLine());

                if (n < 0)
                {
                    break;

                }
                bool b = p.CheckP(n);
                if (b == true)
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not Prime");
                }
            }
        }
    }
}
