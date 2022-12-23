using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double harvest = x * y;
            double wineProducingPortion = 0.40 * harvest;
            double wineLitersProduced = wineProducingPortion / 2.5;

            double difference = Math.Abs(wineLitersProduced - z);

            if(wineLitersProduced < z)
            {
                difference = Math.Floor(difference);
             Console.WriteLine($"It will be a tough winter! More {difference} liters wine needed.");
            }
            else
            {
                wineLitersProduced = Math.Floor(wineLitersProduced);
                Console.WriteLine($"Good harvest this year! Total wine: {wineLitersProduced} liters.");

                double wineLeft = Math.Ceiling(wineLitersProduced -z);
                double winePerWorker = Math.Ceiling(wineLeft / workers);
                Console.WriteLine($"{wineLeft} liters left -> {winePerWorker} liters per person.");
            }

        }
    }
}
