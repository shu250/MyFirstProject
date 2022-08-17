using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._12Aug
{
    class Count
    {
        public static void Frequency(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int count = 1;
                bool isFind = false;
                for (int k = i-1; k >= 0; k--)
                {
                    if (a[i] == a[k])
                    {
                        isFind = true;
                        break;
                    }
                }
                if (isFind == false
                    )
                {


                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(a[i] + "  " + count);
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
                Console.WriteLine("Enter Array Element:");
                a[i] = int.Parse(Console.ReadLine());
            }
            Count.Frequency(a);
        }
    }
}
