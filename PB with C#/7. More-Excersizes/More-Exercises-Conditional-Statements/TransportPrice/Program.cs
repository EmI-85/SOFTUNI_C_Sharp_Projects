using System;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string timeType = Console.ReadLine();

            double taxiPriceDay = 0.70 + 0.79 * n;
            double taxiPriceNight = 0.70 + 0.90 * n;
            double busPriceDayorNight = 0.09 * n; // min 20km
            double trainPriceDayorNight = 0.06 * n; // min 100 km

            if (n < 20)
            {
                if (timeType == "day")
                {
                    Console.WriteLine($"{taxiPriceDay:f}");
                }
                else
                {
                    Console.WriteLine($"{taxiPriceNight:f}");
                }
            }

            else if (n >= 20 && n < 100)
            {
                Console.WriteLine($"{busPriceDayorNight:f}");
            }

            else if (n >= 100)
            {
                Console.WriteLine($"{trainPriceDayorNight:f}");
            }

        }
    }
}
