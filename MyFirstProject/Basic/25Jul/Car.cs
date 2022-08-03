using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._25Jul
{
    class Car
    {
        public string car_name;
        public int model_number;
        public int car_price;
        public string car_color;

        static void Main(string[] args)
        {
            Car audi = new Car();
            audi.car_name = "Audi";
            audi.model_number = 44455;
            audi.car_price = 500000;
            audi.car_color = "black";
            Console.WriteLine(audi.car_name+" "+audi.model_number+" "+audi.car_price+" "+audi.car_color);

            Car creta = new Car();
            creta.car_name = "Creata";
            creta.model_number = 44555;
            creta.car_price = 2100000;
            creta.car_color = "White";
            Console.WriteLine(creta.car_name + " " + creta.model_number + " " + creta.car_price + " " + creta.car_color);

            Car swift = new Car();
            swift.car_name = "Swift";
            swift.model_number = 55433;
            swift.car_price = 700000;
            swift.car_color = "Red";
            Console.WriteLine(swift.car_name+" "+swift.model_number+" "+swift.car_price+" "+swift.car_color);
        }
    }
}
