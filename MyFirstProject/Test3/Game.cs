using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test3
{
    class Game
    {
        public void DisplayGame(string country)
        {
            string ch = country;
            switch (ch)
            {
                case "India": Console.WriteLine("Hockey");
                    break;
                case "China": Console.WriteLine("Table Tennis");
                    break;
                case "Bangladesh": Console.WriteLine("Kabaddi");
                    break;
                case "Italy": Console.WriteLine("Football");
                    break;
                case "United State": Console.WriteLine("BaseBall");
                    break;
                default: Console.WriteLine("Dose not exist Country");
                    break;

            }
        }
        static void Main(string[] args)
        {
            Game g = new Game();
            Console.WriteLine("Enter Country:");
            string c = Console.ReadLine();
            g.DisplayGame(c);

        }
    }
}
