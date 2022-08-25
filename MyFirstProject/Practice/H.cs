using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Practice
{
    class H
    {
        public static void Happy(int n)
        {
            bool isOdd = true;
            while (n > 0)
            {
                int r = n % 10;
                if (r%2== 0)
                {
                    isOdd = false;
                    break;
                }
                n = n / 10;
            }
            if (isOdd == true)
            {
                Console.WriteLine("Happy");
            }
            else
            {
                Console.WriteLine("Not Happy");
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Happy(n);
        }
    }
}
