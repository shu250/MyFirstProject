using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test3
{
    class Shopping
    {
        public void doTransaction(string c)
        {
            Console.WriteLine("You got 15% discount on bill on Creditcard Transaction.");
        }
        public void doTransaction(string d,int a)
        {
            Console.WriteLine("No Discount on bill on Debit Card Transaction.");
        }
        static void Main(string[] args)
        {
            Shopping s = new Shopping();
            Console.WriteLine("Enter Payment Type:CreditCard/DebitCard");
            string c = Console.ReadLine();
            if (c == "CreditCard")
            {
                s.doTransaction(c);
            }
            else
            {
                s.doTransaction(c, 1);
            }
       
        }
    }
}
