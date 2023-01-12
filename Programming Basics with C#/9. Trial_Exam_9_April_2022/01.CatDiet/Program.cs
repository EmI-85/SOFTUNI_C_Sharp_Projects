using System;

namespace _01.CatDiet
{
    class Program
    {
        static void Main(string[] args)
        {
            int percentageFats = int.Parse(Console.ReadLine());
            int percentageProteins = int.Parse(Console.ReadLine());
            int percentageCarbohydrates = int.Parse(Console.ReadLine());
            int caloriesTotal = int.Parse(Console.ReadLine());
            int percentageWater = int.Parse(Console.ReadLine());

            double gramsFat = (percentageFats / 100.00 * caloriesTotal) / 9;
            double gramsProtein = (percentageProteins / 100.00 * caloriesTotal) / 4;
            double gramsCarbohydrate = (percentageCarbohydrates/ 100.00 * caloriesTotal) / 4;

            double foodGrams = gramsFat + gramsProtein + gramsCarbohydrate;

            double caloriesPerGram = caloriesTotal / foodGrams;

            double realCalories = caloriesPerGram * (1 - (double)percentageWater / 100);

            Console.WriteLine($"{realCalories:f4}");
           
            // 100/100

        }
    }
}
