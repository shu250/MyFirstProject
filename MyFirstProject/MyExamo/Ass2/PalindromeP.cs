using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.MyExamo.Ass2
{
    class PalindromeP
    {
        static void Main(string[] args)
        {


            for (int i = 100; i <= 500; i++)
            {
                int n = i;
                int n1 = 0;
                while (n > 0)
                {
                    n1 = n1 * 10 + n%10;
                    n = n / 10;
                    
                }
               // Console.WriteLine(n1);
                if (n1 == i)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }

}
