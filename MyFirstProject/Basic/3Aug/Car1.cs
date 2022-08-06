using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._3Aug
{
    class Car1
    {
        internal string type = "Disel";

    }
    class Maruti : Car1
    {
        internal double price = 800000;
    }
    class Brezza : Maruti
    {
        internal string model = "Lxi";

        public void Show()
        {
            Console.WriteLine(model+" "+price+" "+type);
        }
    }
    class CarInfo
    {
        static void Main(string[] args)
        {
            Brezza b = new Brezza();
            b.Show();
        }
    }

}
