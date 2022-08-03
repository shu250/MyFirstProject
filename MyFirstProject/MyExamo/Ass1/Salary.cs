using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.MyExamo.Ass1
{
    class Salary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Salary:");
            double sal = double.Parse(Console.ReadLine());
            
            if (sal <= 10000)
            {
               sal = sal + (sal / 100 * 20) + (sal / 100 * 80);
            }
            else if (sal <= 20000)
            {
                sal = sal + (sal / 100 * 25) + (sal / 100 * 90);
            }
            else if (sal <= 20000)
            {
                sal = sal + (sal / 100 * 30) + (sal / 100 * 95);
            }
            Console.WriteLine(sal);
        }
    }
}
