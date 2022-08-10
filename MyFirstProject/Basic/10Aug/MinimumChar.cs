using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._10Aug
{
    class MinimumChar
    {
        public char Min(char[] a)
        {
            char M = a[0];
            for (int i= 0; i < a.Length; i++)
            {
                if (M > a[i])
                {
                    M = a[i];
                }
            }
            return M;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Size:");
            int s = int.Parse(Console.ReadLine());
            char[] a = new char[s];
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter Character:");
                a[i] = Convert.ToChar(Console.ReadLine());
            }
            MinimumChar m = new MinimumChar();
            Console.WriteLine("Minimum Character is:"+m.Min(a));
        }
    }
}
