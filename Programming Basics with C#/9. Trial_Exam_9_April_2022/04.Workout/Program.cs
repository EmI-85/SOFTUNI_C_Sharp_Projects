using System;

namespace _04.Workout
{
    class Program
    {
        static void Main(string[] args)
        {
            int trainingDaysNum = int.Parse(Console.ReadLine());
            double kmBaseline = double.Parse(Console.ReadLine());
            int targetKm = 1000;

            double kmRunPerDay = kmBaseline;
            double totalKmRun = 0;

            for (int i = 1; i <= trainingDaysNum; i++)
            {
                int dailyPercentageIncrease = int.Parse(Console.ReadLine());

                kmRunPerDay = kmRunPerDay + (dailyPercentageIncrease / 100.00 * kmRunPerDay);
                totalKmRun += kmRunPerDay;
            }

            double finalKmRun = kmBaseline + totalKmRun;

            if(finalKmRun >= targetKm)
            {
                double overRunKm = Math.Ceiling(finalKmRun - (double)targetKm);
                Console.WriteLine($"You've done a great job running {overRunKm} more kilometers!");
            }
            else
            {
                double notEnoughKm = Math.Ceiling(targetKm * 1.00 - finalKmRun);
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {notEnoughKm} more kilometers");
            }

            // 100/100
        }
    }
}
