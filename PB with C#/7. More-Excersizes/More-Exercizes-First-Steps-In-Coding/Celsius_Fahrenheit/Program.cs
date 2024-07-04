using System;

namespace _03._Celsius_to_Fahrenheit_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double degreesCelsius = double.Parse(Console.ReadLine());
            double degreesFahrenheit = degreesCelsius * 1.8 + 32;

            Console.WriteLine($"{degreesFahrenheit:f2}");

        }
    }
}
