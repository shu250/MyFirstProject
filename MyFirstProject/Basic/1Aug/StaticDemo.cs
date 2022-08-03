using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._1Aug
{
    class StaticDemo
    {
        static int x = 0;
        public void Show()
        {
            x++;
            Console.WriteLine(x);
        }
        static int Addition()
        {
            return 5 + 6;
        }

        static void Main(string[] args)
        {
            StaticDemo s = new StaticDemo();
            StaticDemo s1 = new StaticDemo();
            s.Show();
            s.Show();
            s1.Show();
            int a = Addition();
            Console.WriteLine(a);
        }
    }
}
