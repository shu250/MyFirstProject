using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._29Jul
{ 
    class TypeCasting
    {
        public void Display(int a, float b)
        {
            Console.WriteLine(a + b);
        }
        static void Main(string[] args)
        {
            TypeCasting t = new TypeCasting();
            t.Display(10, 10);

            int a = 8, b = 3;
            float f=1;
            double c = (double)a / b;
            Console.WriteLine(f);
        }
    }
}
