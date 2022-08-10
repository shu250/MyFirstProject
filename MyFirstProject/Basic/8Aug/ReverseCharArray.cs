using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._8Aug
{
    class ReverseCharArray
    {
        public void RevArray(char[] arr)
        { 
             for(int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]+" ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Size:");
            int s = int.Parse(Console.ReadLine());
            char[] arr = new char[s];
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter Charcter:");
                char c = char.Parse(Console.ReadLine());
                arr[i] = c;
            }
            ReverseCharArray a = new ReverseCharArray();
            
            Console.WriteLine(string.Join(" ",arr));
            Console.WriteLine("............................");
            a.RevArray(arr);
        }
    }
}
