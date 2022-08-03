using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._21Jul
{
    class Armstrong
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 digit number:");
            int num = int.Parse(Console.ReadLine());
            int i=1,n,arm=0,c;
             c=num;
            while (i <= num)
            {
                n = num % 10;
                arm = arm + n * n * n;
                num = num / 10;
                
            }
            if (arm == c)
            {
                Console.WriteLine("Number is Armstrong");
            }
            else
            {
                Console.WriteLine("Number is Not Armstrong.");
            }
        }
    }
}
