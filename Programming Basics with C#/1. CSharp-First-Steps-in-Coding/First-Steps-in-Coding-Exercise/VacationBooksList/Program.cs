using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int pagesInBook = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int daysToComplete = int.Parse(Console.ReadLine());

            double pagesPerDay = pagesInBook / (double) daysToComplete;
            double hoursPerDay = pagesPerDay/ pagesPerHour;
            Console.WriteLine((int)hoursPerDay);
            }
    }
}
