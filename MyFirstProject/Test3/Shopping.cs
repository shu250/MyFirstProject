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
        public void doTransaction()
        {
            Console.WriteLine("No Discount on bill on Debit Card Transaction.");
        }
        static void Main(string[] args)
        {
            Shopping s = new Shopping();
            Console.WriteLine("will how pay bill? DebitCard /CreditCard ");
            string c = Console.ReadLine();
            if (c == "CreditCard")
            {
                s.doTransaction(c);
            }
            else if (c == "DebitCard")
            {
                s.doTransaction();
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }

        }
    }
}
