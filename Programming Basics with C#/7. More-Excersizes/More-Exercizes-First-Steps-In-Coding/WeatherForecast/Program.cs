using System;

namespace WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string weatherType = Console.ReadLine();

            if(weatherType == "sunny")
            {
                Console.WriteLine("It's warm outside!");
            }
            else
            {
                Console.WriteLine("It's cold outside!");
            }



        }
    }
}
