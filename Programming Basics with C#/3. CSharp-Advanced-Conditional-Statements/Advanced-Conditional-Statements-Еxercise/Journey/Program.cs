using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string accomodationType = "";
            string destination = "";
            double tripPrice = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if(season == "summer")
                {
                    accomodationType = "Camp";
                    tripPrice = 0.30 * budget;
                    Console.WriteLine($"Somewhere in {destination}");
                    Console.WriteLine($"{accomodationType} - {tripPrice:f2}");
                }
                else if (season == "winter")
                {
                    accomodationType = "Hotel";
                    tripPrice = 0.70 * budget;
                    Console.WriteLine($"Somewhere in {destination}");
                    Console.WriteLine($"{accomodationType} - {tripPrice:f2}");
                }
            }
            else if(budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    accomodationType = "Camp";
                    tripPrice = 0.40 * budget;
                    Console.WriteLine($"Somewhere in {destination}");
                    Console.WriteLine($"{accomodationType} - {tripPrice:f2}");
                }
                else if (season == "winter")
                {
                    accomodationType = "Hotel";
                    tripPrice = 0.80 * budget;
                    Console.WriteLine($"Somewhere in {destination}");
                    Console.WriteLine($"{accomodationType} - {tripPrice:f2}");
                }
            }
            else if(budget > 1000)
            {
                destination = "Europe";
                accomodationType = "Hotel";
                tripPrice = 0.90 * budget;
                Console.WriteLine($"Somewhere in {destination}");
                Console.WriteLine($"{accomodationType} - {tripPrice:f2}");
            }
        }
    }
}
