using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._4Aug
{

    class Fahrenheit
    {
        public float Celcius(float f)
        {
            float c = (f - 32) * (float)5 / 9;
            return c;
        }
        static void Main(string[] args)
        {
            Fahrenheit c = new Fahrenheit();
            Console.WriteLine("Enter Temperature:");
            float f = float.Parse(Console.ReadLine());
            Console.WriteLine("Celcius:"+c.Celcius(f));

        }
    }
}
