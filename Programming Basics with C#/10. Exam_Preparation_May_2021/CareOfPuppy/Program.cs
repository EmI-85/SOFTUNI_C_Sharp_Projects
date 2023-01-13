using System;

namespace CareOfPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodAvailable = int.Parse(Console.ReadLine()) * 1000;
            int foodEatenOverall = 0;

            while(true)
            {
                string input = Console.ReadLine();

                if(input == "Adopted")
                {
                    break;
                }

                int gramsEatenPerMeal = int.Parse(input);
                
                foodEatenOverall += gramsEatenPerMeal;
            }

            if(foodEatenOverall <= foodAvailable)
            {
                int foodLeftover = foodAvailable - foodEatenOverall;
                Console.WriteLine($"Food is enough! Leftovers: {foodLeftover} grams.");
            }
            else
            {
                int foodShortage = foodEatenOverall - foodAvailable;
                Console.WriteLine($"Food is not enough. You need {foodShortage} grams more.");
            }

        }
    }
}
