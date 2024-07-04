using System;

namespace MovieRevenue
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int daysNum = int.Parse(Console.ReadLine());
            int ticketsNum = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            int percentage = int.Parse(Console.ReadLine());

            double revenuePerDay = ticketsNum * ticketPrice;
            double revenueAllDays = revenuePerDay * daysNum;
            double totalRevenue = revenueAllDays - (((double)percentage / 100) * revenueAllDays);

            Console.WriteLine($"The profit from the movie {movieName} is {totalRevenue:f2} lv.");

        }
    }
}
