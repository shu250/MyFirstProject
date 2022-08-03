using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic
{
    class IncrDecre
    {
        public static void Main1(String[] args)
        {
            int a = 10;
            int b = 20;
            int x = a++ - --b + a;
            Console.WriteLine(x + " " + a + " " + b);



        }
    }
}
