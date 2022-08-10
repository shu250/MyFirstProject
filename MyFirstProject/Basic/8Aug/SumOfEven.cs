using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._8Aug
{
    class SumOfEven
    {
        public int Sum()
        {
            int s = 0;
            for(int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    s = s + i;
                }
            }
            return s;
        }
        static void Main(string[] args)
        {
            SumOfEven e = new SumOfEven();
            Console.WriteLine(e.Sum());
        }
    }
}
