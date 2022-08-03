using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._2Aug
{
    class Car
    {
        int model;
        string name;
        double price;
        Engine en;
        public int Model
        {
            get;
            set;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public Engine En
        {
            get { return en; }
            set { en = value; }
        }
    }
    class Engine
    {
        string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
    class CarInfo
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Model = 86828;
            c.Name = "BMW";
            c.Price = 7010000;
            c.En = new Engine();
            c.En.Type = "Disel";

            Console.WriteLine("Model:"+c.Model+"\nName:"+c.Name+"\nPrice:"+c.Price+"\nType:"+c.En.Type);
        }
    }
}
