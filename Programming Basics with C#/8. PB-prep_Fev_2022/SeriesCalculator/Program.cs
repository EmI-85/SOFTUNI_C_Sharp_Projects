using System;

namespace _01.SeriesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string seriesName = Console.ReadLine();
            int seasonsNum = int.Parse(Console.ReadLine());
            int episodesNum = int.Parse(Console.ReadLine());
            double episodeTime = double.Parse(Console.ReadLine());

            double regularTimeNeeded = seasonsNum * episodesNum * episodeTime;
            double additionalTimeNeeded = seasonsNum * 10 + (0.20 * regularTimeNeeded);
            double totalTime = Math.Floor(regularTimeNeeded + additionalTimeNeeded);

            Console.WriteLine($"Total time needed to watch the {seriesName} series is {totalTime} minutes.");
        }
    }
}
