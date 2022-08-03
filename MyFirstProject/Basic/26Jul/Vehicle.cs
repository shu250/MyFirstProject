using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._26Jul
{
    class Vehicle
    {
        public int model;
        public string type;
        public int wheel;
        public int avg;

        public void Access(int vmodel,string vtype,int vwheel)
        {
            model = vmodel;
            type = vtype;
            wheel = vwheel;
        }
        public void AcceptAvg()
        {
            if (wheel == 2)
            {
                avg = 55;
            }
            else if (wheel == 4)
            {
                avg = 16;
            }
            else if (wheel == 6)
            {
                avg = 12;
            }
            else if(wheel>=8 && wheel <= 12)
            {
                avg = 8;
            }
        }
        public void Display()
        {
            Console.WriteLine(model+" "+type+" "+" "+wheel+" "+avg);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Model:");
            int model= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Type");
            string type = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Number of Wheel");
            int wheel = int.Parse(Console.ReadLine());

            Vehicle v = new Vehicle();
            v.Access(model, type, wheel);
            v.AcceptAvg();
            v.Display();
        }
    }
}
