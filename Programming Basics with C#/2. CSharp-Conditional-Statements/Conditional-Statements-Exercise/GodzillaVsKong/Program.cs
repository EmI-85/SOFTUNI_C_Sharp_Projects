using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            int numberOfPeople = int.Parse(Console.ReadLine());
            double clothesPricePerPerson = double.Parse(Console.ReadLine());

            double decorPrice = 0.10 * movieBudget;
            double clothesTotalPrice = numberOfPeople * clothesPricePerPerson;

            if (numberOfPeople > 150)
            {
                double discountforClothes = 0.10 * clothesTotalPrice;
                clothesTotalPrice = clothesTotalPrice - discountforClothes;
            }

            double totalMovieCosts = clothesTotalPrice + decorPrice;

            if(totalMovieCosts > movieBudget)
            {
                double moneyShortage = totalMovieCosts - movieBudget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyShortage:f2} leva more.");
                }
            
            else if (totalMovieCosts <= movieBudget)
            {
                double moneyResidual = movieBudget - totalMovieCosts;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyResidual:f2} leva left."); 
            }

        }
    }
}
