using System;

namespace FishLand
{
    class Program
    {
        static void Main(string[] args)
        {
            double skumriaPricePerKg = double.Parse(Console.ReadLine());
            double cacaPricePerKg = double.Parse(Console.ReadLine());
            double palamudKilos = double.Parse(Console.ReadLine());
            double safridKilos = double.Parse(Console.ReadLine());
            double midiKilos = double.Parse(Console.ReadLine());

            double midiPricePerKg = 7.50;
            double palamudPricePerKg = skumriaPricePerKg * 1.6;
            double safridPricePerKg = cacaPricePerKg * 1.8;

           double bill = palamudKilos*palamudPricePerKg + safridKilos*safridPricePerKg + midiKilos*midiPricePerKg;

            Console.WriteLine($"{bill:f2}");

        }
    }
}
