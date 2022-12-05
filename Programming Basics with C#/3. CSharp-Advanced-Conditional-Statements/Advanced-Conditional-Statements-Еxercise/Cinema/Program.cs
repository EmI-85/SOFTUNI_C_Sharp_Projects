using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double fullSalon = rows * columns;
            double totalIncome = 0;

            switch (movieType)
            { 
                case "Premiere":
                    totalIncome = fullSalon * 12.0;
                    Console.WriteLine($"{totalIncome:f2} leva");
                    break;
                case "Normal":
                    totalIncome = fullSalon * 7.5;
                    Console.WriteLine($"{totalIncome:f2} leva");
                    break;
                case "Discount":
                    totalIncome = fullSalon * 5.0;
                    Console.WriteLine($"{totalIncome:f2} leva");
                    break;
             }


        }
    }
}
