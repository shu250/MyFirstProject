using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test1
{
    class _4
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 1;
            int z = 0;
            for(int i = 1; i <= 20; i++)
            {
                Console.Write(z+" ");
                x = y;
                y = z;
                
                z = x + y;
        
            }
        }
    }
}
