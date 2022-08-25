using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.MyExamo.Array
{
    class _1
    {
        /*static void Main(string[] args)
       {
            Console.WriteLine("Enter Array Size:");
            int s = int.Parse(Console.ReadLine());
            int[] a = new int[s];
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter Array Element:");
                a[i] = int.Parse(Console.ReadLine());

            }
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }*/
        public void MN(int n)
        {
            int m = n % 10;
            while (n > 0)
            {
                int r = n % 10;
                if (m < r)
                {
                    m = r;
                }
                n = n / 10;
            }
            Console.WriteLine(m);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int n = int.Parse(Console.ReadLine());
            _1 m = new _1();
             m.MN(n);
            

        }
    }
}
