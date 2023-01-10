using System;

namespace FamilyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nightsNum = int.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine()); 
            int percentageAdditionalcosts = int.Parse(Console.ReadLine());

            if(nightsNum > 7)
            {
                pricePerNight = 0.95 * pricePerNight;
            }

            double additionalCosts = ((double)percentageAdditionalcosts / 100) * budget;
            double tripCosts = nightsNum * pricePerNight + additionalCosts;

            if(budget >= tripCosts)
            {
                double moneyLeft = budget - tripCosts;
                Console.WriteLine($"Ivanovi will be left with {moneyLeft:f2} leva after vacation.");
            }
            else
            {
                double moneyNeeded = tripCosts - budget;
                Console.WriteLine($"{moneyNeeded:f2} leva needed.");
            }

        }
    }
}
