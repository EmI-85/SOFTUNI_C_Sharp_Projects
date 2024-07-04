using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            int foodLeftByOwner = int.Parse(Console.ReadLine());
            double dogFoodPerDay = double.Parse(Console.ReadLine());
            double catFoodPerDay = double.Parse(Console.ReadLine());
            double turtleFoodPerDay = double.Parse(Console.ReadLine());

            double dogFoodNeeded = dogFoodPerDay * numberOfDays;
            double catFoodNeeded = catFoodPerDay * numberOfDays;
            double turtleFoodNeeded = turtleFoodPerDay / 1000 * numberOfDays;
            double totalFoodNeeded = dogFoodNeeded + catFoodNeeded + turtleFoodNeeded;

            if (totalFoodNeeded <= foodLeftByOwner)
            {
                double foodDifferenceInKilos = Math.Floor(foodLeftByOwner - totalFoodNeeded);
                Console.WriteLine($"{foodDifferenceInKilos} kilos of food left.");
            }
            else
            {
                double foodDifferenceInKilos = Math.Ceiling(totalFoodNeeded - foodLeftByOwner);
                Console.WriteLine($"{foodDifferenceInKilos} more kilos of food are needed.");
            }

        }
    }
}
