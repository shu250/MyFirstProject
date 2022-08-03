using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.MyExamo.Ass2
{
    class AutoMorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            bool isAutomorphic = false;
            for(int i = 1; i <= num / 2; i++)
            {
                if (num == i * i)
                {
                    Console.WriteLine(i);
                    isAutomorphic = true;
                    break;
                }
            }
            if (isAutomorphic == true)
            {
                Console.WriteLine("Automorphic");
            }
            else
            {
                Console.WriteLine("Not AutoMorphic");
            }
        }
    }
}
