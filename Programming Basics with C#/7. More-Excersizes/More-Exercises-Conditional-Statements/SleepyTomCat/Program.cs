using System;

namespace SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int freeDays = int.Parse(Console.ReadLine());
            int workingDays = 365 - freeDays;
            int yearlyNorm = 30000;
            int workingDayPlayPerDay = 63;
            int freeDayPlayPerDay = 127;

            double actualPlay = freeDays * freeDayPlayPerDay + workingDayPlayPerDay * workingDays;
            double timeOverNorm = Math.Abs(actualPlay - yearlyNorm);
           
            if (actualPlay > yearlyNorm)
            {
                double H = Math.Floor(timeOverNorm / 60);
                double M = timeOverNorm % 60;

                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{H} hours and {M} minutes more for play");
            }
            else if(actualPlay <= yearlyNorm)
            {
                double H = Math.Floor(timeOverNorm / 60);
                double M = timeOverNorm % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{H} hours and {M} minutes less for play");
            }

        }
    }
}
