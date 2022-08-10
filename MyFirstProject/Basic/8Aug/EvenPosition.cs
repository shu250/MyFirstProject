using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._8Aug
{
    class EvenPosition
    {
        public void Display(int[] a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(a[i]+" ");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array Size:");
            int s = int.Parse(Console.ReadLine());
            int[] a = new int[s];
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter Value:");
                a[i] = int.Parse(Console.ReadLine());   
            }
            EvenPosition e = new EvenPosition();
            e.Display(a);
        }
    }
}
