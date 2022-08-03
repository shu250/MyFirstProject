using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._28Jul
{
    class AreaC
    {
        double PI = 3.14;
        double Area(double r)
        {
            return PI * r * r;
        }
        double Area(double b,double h)
        {
            return (b * h) * 0.5;
        }
        double Area(double l,float b)
        {
            return (l * Convert.ToDouble(b));
        }
        double Area(float s)
        {
            return Convert.ToDouble(s) * s;
        }
        static void Main(string[] args)
        {
            AreaC a = new AreaC();
            Console.WriteLine("Area of Circle:"+a.Area(3.4));
            Console.WriteLine("Area of Tringle:"+a.Area(5.4,6.5));
            Console.WriteLine("Area of Rectangle:"+a.Area(4.5,3.5f));
            Console.WriteLine("Area of Square:"+a.Area(4.0f));
        }
    }
}
