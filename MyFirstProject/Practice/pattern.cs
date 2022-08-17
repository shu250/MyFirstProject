using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Practice
{
    class pattern
    {
        static void Main(string[] args)
        {


            for (int i = 2; i <= 100; i=i+2)
            {
                for(int j = 2; j <= i; j=j+2) 
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
        }

    }
}
