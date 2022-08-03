using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._2Aug
{
    class Car1
    {
        int model;
        string name;
        long price;
        Engine1 en;
        public Car1(int model,string name,long price,Engine1 en)
        {
            this.model = model;
            this.name = name;
            this.price = price;
            this.en = en;
        }
        public void Show()
        {
            Console.WriteLine("Model:"+model+"\nName:"+name+"\nPrice:"+price);
            en.Show1();
        }
        static void Main(string[] args)
        {
            Engine1 e = new Engine1("Petrol");
            Car1 c = new Car1(4343, "Swift", 70000, e);
            c.Show();
        }

    }
    class Engine1
    {
        string type;
        public Engine1(string type)
        {
            this.type = type;
        }
       public void Show1()
        {
            Console.WriteLine("Type:"+type);
        }
    }
}
