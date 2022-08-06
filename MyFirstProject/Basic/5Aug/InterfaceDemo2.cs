using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._5Aug
{
    interface IDrawble
    {
        public void Draw();
    }
    interface IPrintble
    {
        public void Print();
    }
    class Shape : IPrintble, IDrawble
    {
        public void Draw()
        {
            Console.WriteLine("Drow Shape");
        }
        public void Print()
        {
            Console.WriteLine("Print Shape");
        }
    }
    class InterfaceDemo2
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            s.Draw();
            s.Print();
        }
    }
}
