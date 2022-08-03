using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._2Aug
{
    class Address1
    {
        string city;
        int pin;
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public int Pin
        {
            get { return pin; }
            set { pin = value; }
        }
    }
    class Person1
    {
        int id;
        string name;
        Address1 adr; 
        public int Id 
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Address1 Adr
        {
            get { return adr; }
            set { adr = value; }

        }
    }
    class PersonInfo
    {
        static void Main(string[] args)
        {
            Person1 p = new Person1();
            p.Id = 10;
            p.Name = "Ganesh";
            p.Adr = new Address1();
            p.Adr.City = "Pune";
            p.Adr.Pin = 42134;

            Console.WriteLine("id:"+p.Id+"\nName:"+p.Name+"\nCity:"+p.Adr.City+"\nPin:"+p.Adr.Pin);

        }
    }
   
}
