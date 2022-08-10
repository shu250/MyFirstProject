using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._8Aug
{
    class SumOfEvenArray
    {
        public int EvenSum(int[] arr)
        {
            int sum = 0;
            foreach(int i in arr)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Size:");
            int s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter Number:");
                arr[i] = int.Parse(Console.ReadLine());
            }
            SumOfEvenArray sa = new SumOfEvenArray();
            int a = sa.EvenSum(arr);
            Console.WriteLine("Sum:"+a);
        }
    }
}
