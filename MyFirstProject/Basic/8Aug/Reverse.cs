using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._8Aug
{
    class Reverse
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 4 ,6 ,2 ,9 };
            Console.WriteLine(string.Join(" ",arr));
            Console.WriteLine("...............................");
            for(int i = arr.Length-1; i >= 0; i--)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
