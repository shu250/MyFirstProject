using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._19Jul
{
    class AgeWeight
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Age:");
            float age = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Weight:");
            float w = float.Parse(Console.ReadLine());
            if(age>=18)
            {
                if(w>=50)
                {
                    Console.WriteLine("Person is Eligible For Blood Donation.");
                }
                else
                {
                    Console.WriteLine("Person is Not Eligible For BloodDonation.");
                }
            }
            else
            {
                Console.WriteLine("Person is not Eligible For Blood Donation.");
            }
        }

    }
}
