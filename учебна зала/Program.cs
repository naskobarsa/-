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

            double teglo = double.Parse(Console.ReadLine());
            string tip = Console.ReadLine();
            double km = double.Parse(Console.ReadLine());

            double price = 0;

            if (tip == "standard")
            {
                if (teglo < 1)
                {
                    price = km * 0.03;
                }
                else if (teglo>=1 && 10>=teglo)
                {
                    price = km * 0.05;
                }
                else if (teglo > 10 && 40 >= teglo)
                {
                    price = km * 0.1;
                }
                else if (teglo > 40 && 90.00 >= teglo)
                {
                    price = km * 0.15;
                }
                else if (teglo > 90 && 150.00 >= teglo)
                {
                    price = km * 0.2;
                }
            }

           else
	        {
                if (teglo < 1)
                {
                    price = teglo* (0.8* 0.03)*km + km * 0.03;
                }
                else if (teglo >= 1 && 10 >= teglo)
                {
                    price = teglo*(0.4 * 0.05)*km + km * 0.05;
                }
                else if (teglo >= 11 && 40 >= teglo)
                {
                    price = teglo*(0.05 * 0.1)*km + km * 0.1;
                }
                else if (teglo >= 41 && 90 >= teglo)
                {
                    price = teglo*(0.02 * 0.15)*km + km*0.15;
                }
                else if (teglo >= 91 && 150.00 >= teglo)
                {
                    price = teglo*(0.01* 0.20)*km + km * 0.20;
                }
            }

            Console.WriteLine("The delivery of your shipment with weight of {0:f3} kg. would cost {1:f2} lv.",teglo,price);
        }
    }
}

                

