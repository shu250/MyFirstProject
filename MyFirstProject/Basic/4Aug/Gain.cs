using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._4Aug
{
    class Gain
    {
        public float FindGain(float sp,float cp)
        {
            float g = ((float)(sp - cp) / (float)cp) * 100;
            return g;
        }
        static void Main(string[] args)
        {
            Gain g = new Gain();
            Console.WriteLine("Gain:"+g.FindGain(28.60f,27.50f));
        }
    }
}
