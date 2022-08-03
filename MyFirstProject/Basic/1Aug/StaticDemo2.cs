using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._1Aug
{
    class StaticDemo2
    {
        int x = 10;
        static int y = 20;
        public void Addition()
        {
            Console.WriteLine("Hiiiii");
        }
        static void Add(int a,int b)
        {
            StaticDemo2 s = new StaticDemo2();
            Console.WriteLine(a + b);
            s.Addition();
        }
        static void Main(string[] args)
        {
            StaticDemo2 s = new StaticDemo2();
           // Console.WriteLine(s.Addition());
            Add(2,4);
        }
    }
}
