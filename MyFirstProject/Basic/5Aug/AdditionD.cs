using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._5Aug
{
    abstract class Addition
    {
        public int a = 10;
    }
    interface IAddble
    {
        static int b=50;
    }
    class Sum : Addition, IAddble
    {
        public void CalculateSum()
        {

            Console.WriteLine(a+IAddble.b);
        }
    }
    class AdditionD
    {
        static void Main(string[] args)
        {
            Sum s = new Sum();
            s.CalculateSum();
        }
    }
}
