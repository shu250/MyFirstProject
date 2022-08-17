using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test4
{
    class Car
    {
        public int CarId;
        public string CarColor;
        public Engine en;
        public Gear g;
        public Car(int CarId,string CarColor,Engine en,Gear g)
        {
            this.CarColor = CarColor;
            this.CarId = CarId;
            this.en = en;
            this.g = g;
        }
        public void DCar()
        {
            Console.WriteLine("Car Id:"+CarId+"\n CarColor:"+CarColor);
            en.DEngine();
            g.DGear();
        }
    }
    class Engine
    {
        public int eid;
        public string lastenginecleandate;
        public SubEngine s;
        
        public Engine(int eid,string lastenginecleandate,SubEngine s)
        {
            this.eid = eid;
            this.lastenginecleandate = lastenginecleandate;
            this.s = s;
            
        }
        public void DEngine()
        {
            Console.WriteLine("Engine Id:"+eid+"\n Last Engine Clean Date:"+lastenginecleandate);
            s.DSubEngine();
        }
    }
    class SubEngine
    {
        public string subenginetype;
        public SubEngine(string subenginetype)
        {
            this.subenginetype = subenginetype;
        }
        public void DSubEngine()
        {
            Console.WriteLine("SubEngine Type:"+subenginetype);
        }
    }
    class Gear
    {
        public string type;
        public Gear(string type)
        {
            this.type = type;
        }
        public void DGear()
        {
            Console.WriteLine("Gear Type:"+type);
        }
    }
    class _8
    {
        static void Main(string[] args)
        {


            Gear g = new Gear("Auto");
            SubEngine s = new SubEngine("Disel");
            Engine en;
            en = new Engine(1001, "1 Aug", s);
            Car c = new Car(2002, "White", en, g);
            c.DCar();
        }


    }
}
