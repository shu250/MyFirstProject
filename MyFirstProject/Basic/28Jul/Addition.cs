using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._28Jul
{
    class Addition
    {
        int Calculate(int a,int b)
        {
            return a + b;
        }
        int Calculate(int a,float b)
        {
            return a - Convert.ToInt32(b);
        }
        int Calculate(float a,int b)
        {
            return Convert.ToInt32(a) * b;
        }
         int Calculate(float a,float b)
        {
            return Convert.ToInt32(a) / Convert.ToInt32(b);
        }
        static void Main(string[] args)
        {
            Addition a = new Addition();
            Console.WriteLine( a.Calculate(10, 20));
            Console.WriteLine( a.Calculate(20, 10.0f));
            Console.WriteLine(a.Calculate(13.0f, 4.0f));
            Console.WriteLine(a.Calculate(3.0f, 5));
        }

    }
}
