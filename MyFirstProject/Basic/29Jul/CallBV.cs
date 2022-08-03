using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._29Jul
{
    class CallBV
    {
       public void  Switch(ref int num1,ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }    
        static void Main(string[] args)
        {
            CallBV c = new CallBV();
            Console.WriteLine("Enter Number 1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number 2:");
            int num2 = int.Parse(Console.ReadLine());
            c.Switch(ref num1, ref num2);
            Console.WriteLine(num1+" "+num2);
            Console.WriteLine("-----------------------------");
            c.Switch(ref num1, ref num2);
            Console.WriteLine(num1+" "+num2);
        }
    }
}
