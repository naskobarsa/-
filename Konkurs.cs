using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03___Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var dancers = int.Parse(Console.ReadLine());
            var points = double.Parse(Console.ReadLine());           
            string season = Console.ReadLine();
            string country = Console.ReadLine();

            var total = 0.00;

            if (country == "Bulgaria")
                
            {
                if (season == "summer")

                {
                    total = dancers * points*0.95;
                }
                else if (season == "winter")
                {
                    total = dancers * points*0.92;
                }

            }

            
            else
                
            {
                if (season == "summer")
                {
                    total = (dancers * points) * 1.5*0.90;
                }
                else if (season == "winter")
                {
                    total = (dancers * points) * 1.5*0.85;
                }
            } 
            


        }  
    }
}