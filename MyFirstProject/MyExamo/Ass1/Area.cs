using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.MyExamo.Ass1
{
    class Area
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Area Of Circle\n2.Area of Square\n3.Area of Righr Angle Tringle\n4.Area of Rectangle\n5.Circumference of a circle \n6.Perimeter of a square");
            int choice = int.Parse(Console.ReadLine());
            float PI = 3.14f;
            switch (choice)
            {
                case 1: Console.WriteLine("Enter Redius:");
                    float r = float.Parse(Console.ReadLine());
                    float a = PI * r * r;
                    Console.WriteLine("Area of Circle:"+a);
                    break;
                case 2: Console.WriteLine("Enter Side:");
                    float s = float.Parse(Console.ReadLine());
                    float sa = s * s;
                    Console.WriteLine("Area of Square:"+sa);
                    break;
                case 3: Console.WriteLine("Enter Base:");
                    float b = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Height:");
                    float h = float.Parse(Console.ReadLine());
                    float ra = b * h * 0.5f;
                    Console.WriteLine("Area of RightAngle Tringle:" + ra);
                    break;
                case 4:Console.WriteLine("Enter Length:");
                    float l = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Width:");
                    float w = float.Parse(Console.ReadLine());
                    float ar = l * w;
                    Console.WriteLine("Area of Rectangle="+ar);
                    break;
                case 5: Console.WriteLine("Enter Radius:");
                    float rr = float.Parse(Console.ReadLine());
                    float cc = 2 * PI * rr;
                    Console.WriteLine("Circumferance of Circle:"+cc);
                    break;
                case 6:Console.WriteLine("Enter Side:");
                    float si = float.Parse(Console.ReadLine());
                    float ps = 4 * si;
                    Console.WriteLine("Perimeter Of Square:" + ps);
                    break;
                default:Console.WriteLine("Invalid Input.");
                    break;

            }
        }
    }
}
