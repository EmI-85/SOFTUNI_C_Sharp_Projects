using System;

namespace Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfbottles = int.Parse(Console.ReadLine());
            
            double detergentQuantity = numberOfbottles * 750;
            double quantityUsed = 0;
            int numberOfWashedDishes = 0;
            int numberOfWashedPots = 0;
            int washingCounter = 0;

            string command = Console.ReadLine();

            while (command != "End")
            {
               int numberOfIteamsToWash = int.Parse(command);
                double remainingDetergent = detergentQuantity - quantityUsed;

                if(washingCounter % 3 == 0)
                {
                    quantityUsed += numberOfIteamsToWash * 15;
                    numberOfWashedPots += numberOfIteamsToWash;
                    washingCounter++;
                }
                else
                { 
                quantityUsed += numberOfIteamsToWash * 5;
                numberOfWashedDishes += numberOfIteamsToWash;
                washingCounter++;
                }

                if (remainingDetergent < 0 )
                {
                    double quantityNeeded = quantityUsed - detergentQuantity;
                    Console.WriteLine($"Not enough detergent, {quantityNeeded} ml. more necessary!");
                }
            }

            double quantityLeft = detergentQuantity - quantityUsed;

            Console.WriteLine($"Detergent was enough!");
            Console.WriteLine($"{numberOfWashedDishes} dishes and {numberOfWashedPots} pots were washed.");
            Console.WriteLine($"Leftover detergent {quantityLeft} ml.");


        }
    }
}
