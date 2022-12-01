using System;

namespace LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string tvSeriesName = Console.ReadLine();
            int episodeDuration = int.Parse(Console.ReadLine());
            int lunchBreakDuration = int.Parse(Console.ReadLine());
            double lunchDuration = 0.125 * lunchBreakDuration;
            double restDuration = 0.25 * lunchBreakDuration;

            double timeLeftForWatchingEpisode = lunchBreakDuration - (lunchDuration + restDuration);

            double remainingTime = Math.Ceiling(timeLeftForWatchingEpisode - episodeDuration);
            double shortageOfTime = Math.Ceiling(episodeDuration - timeLeftForWatchingEpisode);

            if (timeLeftForWatchingEpisode >= episodeDuration)
            {
                Console.WriteLine($"You have enough time to watch {tvSeriesName} and left with {remainingTime} minutes free time.");
            }
            else 
            {
                Console.WriteLine($"You don't have enough time to watch {tvSeriesName}, you need {shortageOfTime} more minutes.");
            }

        }
    }
}
