using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._1Aug
{
    class StaticOverloading
    {
        static int Calculator(int a,int b)
        {
            return a + b;
        }
        static int Calculator(int a,float b)
        {
            return a - (int)b;
        }
        static int Calculator(float a,float b)
        {
            return (int)a * (int)b;
        }
        static int Calculator(float a,int b)
        {
            return (int)a / b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Addition:"+Calculator(10,20));
            Console.WriteLine("Substraction:" + Calculator(20, 10f));
            Console.WriteLine("Multiplication:"+Calculator(5f,5f));
            Console.WriteLine("Division:"+Calculator(25f,5));
        }
    }
}
