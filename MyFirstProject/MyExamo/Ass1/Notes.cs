using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.MyExamo.Ass1
{
    class Notes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Amount:");
            int amt = int.Parse(Console.ReadLine());
            
             int tt=amt / 2000;
             amt = amt % 2000;
            int fh = amt / 500;
            amt = amt % 500;
            int th = amt / 200;
            amt = amt % 200;
            int oh = amt / 100;
            amt = amt % 100;
            int f = amt / 50;
            amt = amt % 50;
            int t = amt / 20;
            amt = amt % 20;
            int t1 = amt / 10;
            amt = amt % 10;
            int o = amt / 1;
            int tn = tt + fh + th + oh + f + t + t1 + o;
            Console.WriteLine(tn);
            
        }
    }
}
