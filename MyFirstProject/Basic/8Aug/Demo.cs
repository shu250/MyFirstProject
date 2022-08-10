using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._8Aug
{
    class Demo
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 7, 8 };
            int[] arr1 = new int[5];
            for(int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("Enter Element:");
                arr1[i] = int.Parse(Console.ReadLine());

            }
            int[] arr2 = new int[] { 1, 2, 4, 56, 76 };
            Console.WriteLine("..........................................");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("..........................................");
            foreach (int a in arr1)
            {
                Console.Write(a+" ");
            }
            Console.WriteLine();
            Console.WriteLine("..........................................");
            Console.WriteLine(string.Join(" ",arr2));
            Console.WriteLine("..........................................");
        }
    }
}
