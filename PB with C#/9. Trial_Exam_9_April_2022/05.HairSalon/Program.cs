using System;

namespace _05.HairSalon
{
    class Program
    {
        static void Main(string[] args)
        {
            int dailyTarget = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
         
            double moneyEarned = 0;
            bool targetReached = false;

            while(true)
            {
                if (command == "closed")
                {
                    break;
                }

                if (command == "haircut")
                {
                    string serviceType = Console.ReadLine();
                    if (serviceType == "mens")
                    {
                        double priceMen = 15;
                        moneyEarned += priceMen;
                    }
                    else if (serviceType == "ladies")
                    {
                        double priceLadies = 20;
                        moneyEarned += priceLadies;
                    }
                    else if (serviceType == "kids")
                    {
                        double priceKids = 10;
                        moneyEarned += priceKids;
                    }                 
                }

                else if(command == "color")
                {
                    string colorType = Console.ReadLine();

                    if(colorType == "touch up")
                    {
                        double priceTouchUp = 20;
                        moneyEarned += priceTouchUp;
                    }
                    else if(colorType == "full color")
                    {
                        double priceFull = 30;
                        moneyEarned += priceFull;
                    }             
                }
                
                if (moneyEarned >= dailyTarget)
                {
                    targetReached = true;
                    break;
                }
                command = Console.ReadLine();

            }

            if (targetReached)
            {
                Console.WriteLine($"You have reached your target for the day!");
                Console.WriteLine($"Earned money: {moneyEarned}lv.");
            }
            else
            {
                double moneyNeeded = dailyTarget - moneyEarned;
                Console.WriteLine($"Target not reached! You need {moneyNeeded}lv. more.");
                Console.WriteLine($"Earned money: {moneyEarned}lv.");
            }

            // 100/100

        }
    }
}
