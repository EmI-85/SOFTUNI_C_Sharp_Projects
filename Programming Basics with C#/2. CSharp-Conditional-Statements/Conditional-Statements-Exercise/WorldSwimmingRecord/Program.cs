using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double swimmingRecord = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            double waterResistanceDistance = 15;
            double resistanceTimesCalculation = distanceInMeters/waterResistanceDistance;
            double waterResistanceEffect = Math.Floor(resistanceTimesCalculation) * 12.5;

            double ivansTime = distanceInMeters * timeForOneMeter + waterResistanceEffect;
            double timeToRecord = Math.Abs(swimmingRecord - ivansTime);

            if (ivansTime < swimmingRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {ivansTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {timeToRecord:f2} seconds slower.");
            }
        }
    }
}
