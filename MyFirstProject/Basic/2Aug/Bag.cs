using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._2Aug
{
    class Pen
    {
        float p_length;
        string p_name;
        string p_color;
        string type;
        public float P_length
        {
            get { return p_length; }
            set { p_length = value; }
        }
        public string P_name
        {
            get;
            set;
        }
        public string P_color
        {
            get;
            set;
        }
        public string Type
        {
            get;
            set;
        }

    }
    class Bag
    {
        string brand_name;
        int price;
        string color;
        Pen p;
        public string Brand_Name
        {
            get { return brand_name; }
            set { brand_name = value; }
        }
        public int Price
        {
            get;
            set;
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public Pen P
        {
            get;
            set;
        }
    }
    class BagInfo
    {
        static void Main(string[] args)
        {


            Bag b = new Bag();
            b.Brand_Name = "Addidas";
            b.Price = 1000;
            b.Color = "Black";
            b.P = new Pen();
            b.P.P_length = 7;
            b.P.P_color = "Blue";
            b.P.P_name = "cello";
            b.P.Type = "Ball";
            Console.WriteLine(b.Brand_Name+" "+b.Price+" "+b.Color+" "+b.P.P_length+" "+b.P.P_color+" " +b.P.P_name+" " +b.P.Type);
        }
    }
}
