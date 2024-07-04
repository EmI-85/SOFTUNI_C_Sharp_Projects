using System;

namespace FoodforPets
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysNum = int.Parse(Console.ReadLine());
            double foodAvailable = double.Parse(Console.ReadLine());

            double biscuitsTotal = 0;

            double eatenByDog = 0;
            double eatenByCat = 0;

            for (int i = 1; i <= daysNum; i++)
            {
                int dogPerDay = int.Parse(Console.ReadLine());
                int catPerDay = int.Parse(Console.ReadLine());

                eatenByDog += dogPerDay;
                eatenByCat += catPerDay;

                if (i % 3 == 0)
                {
                   double biscuits = (dogPerDay + (double)catPerDay) * 0.10;
                    biscuitsTotal += biscuits;
                }
                
            }

            double eatenByBoth = eatenByCat + eatenByDog;

            double percentageEatenFood = eatenByBoth / foodAvailable * 100;
            double percentageEatenByCat= eatenByCat / eatenByBoth * 100;
            double percentageEatenByDog = eatenByDog / eatenByBoth * 100;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuitsTotal)}gr.");
            Console.WriteLine($"{percentageEatenFood:f2}% of the food has been eaten.");
            Console.WriteLine($"{percentageEatenByDog:f2}% eaten from the dog.");
            Console.WriteLine($"{percentageEatenByCat:f2}% eaten from the cat.");
        }
    }
}
