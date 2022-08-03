using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._21Jul.class1
{
    class Magic
    {
        static void Main(string[] args)
        {
            int magic = 56;
            Console.WriteLine(magic);
            while (true)
            {
                Console.WriteLine("Enter Your Magic No.");
                int mymagic = int.Parse(Console.ReadLine());
                if (mymagic > magic)
                {
                    Console.WriteLine("Entered number is greater Try again.....");
                    continue;
                }
                else if(mymagic<magic)
                {
                    Console.WriteLine("Entered number is small Try again.......");
                }
                else
                {
                    Console.WriteLine("You Gess Corrected...........");
                    break;
                }
                
            }
        }
    }
}
