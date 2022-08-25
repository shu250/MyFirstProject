using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Practice
{ 

    class A
        { 
 void add(int a,int b)
        {

        }
       void add(float a,float b)
        {

        }
        static void Main(string[] args)

        { 
            A ob = new A();
           ob.add(12, 3);
            ob.add(6.7f, 8.9f);
           // ob.siya();
        }
        }
    class Mobile
    {
        public virtual void Call()
        {
            Console.WriteLine("Mobile is Calling");
        }
        public void sendsms()
        {
            Console.WriteLine("Message from parent");
        }
    }
    class Samsung:Mobile
    {
        public override void Call()
        {
            Console.WriteLine("Samsung Mobile Calling");
        }
      
    }
    class OverridingDemo
    {
        static void Main(string[] args)
        {
            Mobile s = new Samsung();
            s.Call();
            s.sendsms();
        }//


    }
}
