using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._25Jul
{
    class Animal
    {
        public string animal_name;
        public int animal_leg;
        public string food_type;
        static void Main(string[] args)
        {
            Animal cow = new Animal();
            cow.animal_name = "Cow";
            cow.animal_leg = 4;
            cow.food_type = "grass";
            Console.WriteLine(cow.animal_name + " " + cow.animal_leg + " " + cow.food_type);
            Animal lion = new Animal();
            lion.animal_name = "Lion";
            lion.animal_leg = 4;
            lion.food_type = "Non Veg";
            Console.WriteLine(lion.animal_name+" "+lion.animal_leg+" "+lion.food_type);
        }
    }
}
