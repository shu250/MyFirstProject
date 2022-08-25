using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._25Aug
{
    class Tuple1
    {
        static Tuple<int,int> Calculator(int a,int b)
        {
            int s = a + b;
            int p = a * b;
            return Tuple.Create(s,p);
        }

        static void Main(string[] args)
        {

        }
    }
    


    
}
