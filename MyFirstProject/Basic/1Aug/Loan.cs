using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._1Aug
{
    class Loan
    {
       
       public double Calculate_Loan(double amount,int ir,int t)
        {
            double tl = (double)(amount * ir * t) / 100;
            return tl;
        }
        public double Calculate_Loan(double amount,int t)
        {
            double tl;
            if (t <= 6)
            {
                 tl = (double)(amount * 10 * t) / 100;
            }
            else
            {
                 tl = (double)(amount * 13 * t) / 100;
            }
            return tl;
        }

        static void Main(string[] args)
        {
            Loan l = new Loan();
            Console.WriteLine(l.Calculate_Loan(20000,11,3));
            Console.WriteLine(l.Calculate_Loan(15000,5));
            Console.WriteLine(l.Calculate_Loan(15000,7));
        }
    }
}
