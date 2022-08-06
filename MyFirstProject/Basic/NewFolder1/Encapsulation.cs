using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic.NewFolder1
{
    class Encap
    {
        int id;
        string name;
        public int Id
        {
            set
            {
                id =value;
            }
            get
            {
                return id;
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void Show()
        {
            Console.WriteLine(Id+" "+Name);
        }
    }
    
    class Encapsulation
    {
        static void Main(string[] args)
        {
            Encap e = new Encap();
            e.Id = 10;
            e.Name = "Rahul";
            Console.WriteLine(e.Id+" "+e.Name);
            e.Show();
        }
    }
}
