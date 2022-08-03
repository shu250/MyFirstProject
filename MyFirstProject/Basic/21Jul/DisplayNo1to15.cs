using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._21Jul
{
    class DisplayNo1to15
    {
        static void Main(string[] args)
        {
            int i=1;
            while (i <= 15)
            {
                if(i%3==0 && i % 9 == 0)
                {
                    break;
                }
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
