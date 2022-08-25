using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test4
{
    class Pen
    {
         Refill r;
         float CapLength;
         string brand;
        public Refill R
        {
            set;
            get;
        }
        public float Clength
        {
            set;
            get;
        }
        public string Brand
        {
            set;
            get;
        }
    }
    class Refill
    {
         string inkcolor;
         float length;
         Nib n;
        public string InkColor
        {
            set;
            get;
        }
        public float Length
        {
            get;
            set;
        }
        public Nib N
        {
            set;
            get;
        }
    }
    class Nib
    {
        string mtype;
        double width;
        public string Mtype
        {
            set;
            get;
        }
        public double Width
        {
            set;
            get;
        }
    }
    class _4
    {
        static void Main(string[] args)
        {
            Pen p = new Pen();
            p.Clength = 4;
            p.Brand = "Cello";
            p.R = new Refill();
            p.R.InkColor = "Blue";
            p.R.Length = 10;
            p.R.N = new Nib();
            p.R.N.Mtype = "Strong";
            p.R.N.Width = 0.5;
            Console.WriteLine(p.Clength+" "+p.Brand+" "+p.R.InkColor+" "+p.R.Length+" "+p.R.N.Mtype+" "+p.R.N.Width);
        }
    }
}
