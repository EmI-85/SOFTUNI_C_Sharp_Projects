using System;

namespace FuelTank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double litersFuelInTank = double.Parse(Console.ReadLine());

            if (fuelType == "Diesel" || fuelType == "Gasoline" || fuelType == "Gas")
            {
                if (litersFuelInTank >= 25)
                {
                    fuelType = fuelType.ToLower();
                    Console.WriteLine($"You have enough {fuelType}.");
                }
                else if (litersFuelInTank < 25)
                {
                    fuelType = fuelType.ToLower();
                    Console.WriteLine($"Fill your tank with {fuelType}!");
                }
            }
            else
                {
                Console.WriteLine($"Invalid fuel!"); 
                }
                    
            }

        }
    }

