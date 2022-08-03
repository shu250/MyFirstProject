using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._27Jul
{
    class Car
    {
        int model_no;
        string c_name;
        long price;
        int speed;

        public int M_NO
        {
            get
            {
                return model_no;
            }
            set
            {
                model_no = value;
            }
        }
        public string C_Name
        {
            get
            {
                return c_name;
            }
            set
            {
                c_name = value;
            }

        }
        public long Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }
    }

    class CarV
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.M_NO = 10001;
            c.C_Name = "Creta";
            c.Speed = 220;
            c.Price = 2100000;

            Console.WriteLine("Model Number:"+c.M_NO+"\n Car Name:"+c.C_Name+"\n Price: "+c.Price+"\nSpeed:"+c.Speed);
        }
    }
}
