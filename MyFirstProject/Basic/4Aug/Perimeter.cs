using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._4Aug
{
    class Perimeter
    {
        public float PerimeterT(float b,float s1,float s2)
        {
            float p = b + s1 + s2;
            return p;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Base:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter side1:");
            float s1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Base2:");
            float s2 = float.Parse(Console.ReadLine());
            Perimeter p = new Perimeter();
           float a= p.PerimeterT(b, s1, s2);
            Console.WriteLine("Perimeter Of Tringle:"+a);
        }
    }
}
