using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._8Aug
{
    class Demo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int s = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[s];
            for(int i = 0; i < arr.Length; i++) 
            {
                Console.WriteLine("Enter Number:");
                arr[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("........................");
            foreach (char c in arr)
            {
                Console.WriteLine(c);
            }
        }
    }
}
