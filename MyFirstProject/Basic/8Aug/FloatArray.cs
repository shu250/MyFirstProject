using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._8Aug
{
    class FloatArray
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array:");
            int s = int.Parse(Console.ReadLine());
            float[] arr = new float[s];
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter Number:");
                arr[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("...............................................");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("...............................................");
            foreach(float a in arr)
            {
                Console.Write(a+" ");
            }
            Console.WriteLine();
            Console.WriteLine("...............................................");
            Console.WriteLine(string.Join(" ",arr));
            Console.WriteLine("...............................................");
        }
    }
}
