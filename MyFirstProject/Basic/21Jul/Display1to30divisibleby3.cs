using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._21Jul
{
    class Display1to30divisibleby3
    {
        static void Main(string[] args)
        {
       
            int i = 1;
            while (i <= 30)
            {
                
                if (i % 3 == 0)
                {
                    i++; 
                    continue;
                }
                Console.WriteLine(i);
                i++;
            }
            
        }
    }
}
