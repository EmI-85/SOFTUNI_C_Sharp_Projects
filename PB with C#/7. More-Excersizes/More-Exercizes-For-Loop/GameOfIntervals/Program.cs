using System;

namespace GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int plays = int.Parse(Console.ReadLine());
            double result = 0;
            int interval1 = 0;
            int interval2 = 0;
            int interval3 = 0;
            int interval4 = 0;
            int interval5 = 0;
            int interval6 = 0;

            for (int i = 1; i <= plays; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if(number >= 0  && number <= 9)
                {
                    result += 0.20 * number;
                    interval1++;
                }
                else if(number >= 10 && number <= 19)
                {
                    result += 0.30 * number;
                    interval2++;
                }
                else if (number >= 20 && number <= 29)
                {
                    result += 0.40 * number;
                    interval3++;
                }
                else if (number >= 30 && number <= 39)
                {
                    result += 50;
                    interval4++;
                }
                else if (number >= 40 && number <= 50)
                {
                    result += 100;
                    interval5++;
                }
                else if (number < 0 || number > 50)
                {
                    result = 0.5 * result;
                    interval6++;
                }

            }

            double percentageInterval1 = interval1 / (double)plays * 100;
            double percentageInterval2 = interval2 / (double)plays * 100;
            double percentageInterval3 = interval3 / (double)plays * 100;
            double percentageInterval4 = interval4 / (double)plays * 100;
            double percentageInterval5 = interval5 / (double)plays * 100;
            double percentageInterval6 = interval6 / (double)plays * 100;

            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {percentageInterval1:f2}%");
            Console.WriteLine($"From 10 to 19: {percentageInterval2:f2}%");
            Console.WriteLine($"From 20 to 29: {percentageInterval3:f2}%");
            Console.WriteLine($"From 30 to 39: {percentageInterval4:f2}%");
            Console.WriteLine($"From 40 to 50: {percentageInterval5:f2}%");
            Console.WriteLine($"Invalid numbers: {percentageInterval6:f2}%");

        }
    }
}
