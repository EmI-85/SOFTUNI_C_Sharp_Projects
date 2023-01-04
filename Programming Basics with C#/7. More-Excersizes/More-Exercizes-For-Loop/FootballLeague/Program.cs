using System;

namespace FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int numberOfFans = int.Parse(Console.ReadLine());

            int sectorA = 0;
            int sectorB = 0;
            int sectorV = 0;
            int sectorG = 0;

            for (int i = 1; i <= numberOfFans; i++)
            {
                string sector = Console.ReadLine();

                if (sector == "A")
                {
                    sectorA++;
                }
                else if (sector == "B")
                {
                    sectorB++;
                }
                else if (sector == "V")
                {
                    sectorV++;
                }
                else if (sector == "G")
                {
                    sectorG++;
                }

            }

            double percentageA = sectorA / (double)numberOfFans * 100;
            double percentageB = sectorB / (double)numberOfFans * 100;
            double percentageV = sectorV / (double)numberOfFans * 100;
            double percentageG = sectorG / (double)numberOfFans * 100;


            double percentageCapacity = numberOfFans / (double)stadiumCapacity * 100;

            Console.WriteLine($"{percentageA:f2}%");
            Console.WriteLine($"{percentageB:f2}%");
            Console.WriteLine($"{percentageV:f2}%");
            Console.WriteLine($"{percentageG:f2}%");
            Console.WriteLine($"{percentageCapacity:f2}%");

        }
    }
}
