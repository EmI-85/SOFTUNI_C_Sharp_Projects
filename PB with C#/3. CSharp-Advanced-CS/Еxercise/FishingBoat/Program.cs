using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfFishermen = int.Parse(Console.ReadLine());

            double shipRentSpring = 3000.00;
            double shipRentSummer = 4200.00;
            double shipRentAutumn = 4200.00;
            double shipRentWinter = 2600.00;
            double shipRentFinal = 0;

            if(season == "Spring")
            {
                if (numberOfFishermen % 2 == 0)
                {
                    if (numberOfFishermen <= 6)
                    {
                        shipRentFinal = (shipRentSpring * 0.9) * 0.95;
                    }
                    else if (numberOfFishermen > 7 && numberOfFishermen <= 11)
                    {
                        shipRentFinal = (shipRentSpring * 0.85) * 0.95;
                    }
                    else if (numberOfFishermen >= 12)
                    {
                        shipRentFinal = (shipRentSpring * 0.75) * 0.95;
                    }
                }
                else
                {
                    if (numberOfFishermen <= 6)
                    {
                        shipRentFinal = shipRentSpring * 0.9;
                    }
                    else if (numberOfFishermen > 7 && numberOfFishermen <= 11)
                    {
                        shipRentFinal = shipRentSpring * 0.85;
                    }
                    else if (numberOfFishermen >= 12)
                    {
                        shipRentFinal = shipRentSpring * 0.75;
                    }
                }
            }
            else if (season == "Summer")
            {
                if (numberOfFishermen % 2 == 0)
                {
                    if (numberOfFishermen <= 6)
                    {
                        shipRentFinal = (shipRentSummer * 0.9) * 0.95;
                    }
                    else if (numberOfFishermen > 7 && numberOfFishermen <= 11)
                    {
                        shipRentFinal = (shipRentSummer * 0.85) * 0.95;
                    }
                    else if (numberOfFishermen >= 12)
                    {
                        shipRentFinal = (shipRentSummer * 0.75) * 0.95;
                    }
                }
                else 
                {
                    if (numberOfFishermen <= 6)
                    {
                        shipRentFinal = shipRentSummer * 0.9;
                    }
                    else if (numberOfFishermen > 7 && numberOfFishermen <= 11)
                    {
                        shipRentFinal = shipRentSummer * 0.85;
                    }
                    else if (numberOfFishermen >= 12)
                    {
                        shipRentFinal = shipRentSummer * 0.75;
                    }
                }
            }
            else if (season == "Autumn")
            {
                if (numberOfFishermen <= 6)
                {
                    shipRentFinal = shipRentAutumn * 0.9;
                }
                else if (numberOfFishermen > 7 && numberOfFishermen <= 11)
                {
                    shipRentFinal = shipRentAutumn * 0.85;
                }
                else if (numberOfFishermen >= 12)
                {
                    shipRentFinal = shipRentAutumn * 0.75;
                }
            }
            else if (season == "Winter")
            {
                if (numberOfFishermen % 2 == 0)
                {
                    if (numberOfFishermen <= 6)
                {
                    shipRentFinal = (shipRentWinter * 0.9) * 0.95;
                }
                else if (numberOfFishermen > 7 && numberOfFishermen <= 11)
                {
                    shipRentFinal = (shipRentWinter * 0.85) * 0.95;
                }
                else if (numberOfFishermen >= 12)
                {
                    shipRentFinal = (shipRentWinter * 0.75) * 0.95;
                }
                }
                else
                {
                    if (numberOfFishermen <= 6)
                    {
                        shipRentFinal = shipRentWinter * 0.9;
                    }
                    else if (numberOfFishermen > 7 && numberOfFishermen <= 11)
                    {
                        shipRentFinal = shipRentWinter * 0.85;
                    }
                    else if (numberOfFishermen >= 12)
                    {
                        shipRentFinal = shipRentWinter * 0.75;
                    }
                }
            }

            if(budget >= shipRentFinal)
            {
                double moneyLeft = budget - shipRentFinal;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }

            if(budget < shipRentFinal)
            {
                double moneyShortage = shipRentFinal - budget;
                Console.WriteLine($"Not enough money! You need {moneyShortage:f2} leva.");
            }
           
        }
    }
}
