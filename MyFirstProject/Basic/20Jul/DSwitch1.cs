using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic._20Jul
{
    class DSwitch1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter City:");
            string city = Convert.ToString(Console.ReadLine());
            switch (city)
            {
                case "Pune":Console.WriteLine("IT.");
                    break;
                case "Mumbai":Console.WriteLine("IT");
                    break;
                case "Nagpur":Console.WriteLine("IT.");
                    break;
                case "Ahmadnagar":Console.WriteLine("MIDC");
                    break;
                case "Aurangabad":Console.WriteLine("MIDC");
                    break;
                default:Console.WriteLine("Invalid Input.");
                        break;
            }
        }
    }
}
