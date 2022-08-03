using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._2Aug
{
    class Address
    {
        public string city;
        public int pin;

        public Address(string city,int pin)
        {
            this.city = city;
            this.pin = pin;
        }
        public void Show()
        {
            Console.WriteLine(city+" "+pin);
        }

    }
    class Person
    {
        int id;
        string name;
        Address adr;
        public Person(int id,string name,Address adr)
        {
            this.id = id;
            this.name = name;
            this.adr = adr;
        }
        public void PShow()
        {
            Console.WriteLine(id+" "+name);
            adr.Show();
        }

        static void Main(string[] args)
        {
            Address a = new Address("pune",40111);
            Person p = new Person(1, "Ajay", a);
            p.PShow();
        }
    }
}
