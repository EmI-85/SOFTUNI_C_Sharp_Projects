using System;

namespace TourismShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            int count = 0;
            int AllProducts = 0;
            double totalSum = 0;
            string text = Console.ReadLine();

            while (text != "Stop")
            {
                double price = double.Parse(Console.ReadLine());
                count++;
                if(count == 3)
                {
                    count = 0;
                    price /= 2;
                }
                if(price + totalSum > budget)
                {
                    double moneyNeeded = price + totalSum - budget;
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {moneyNeeded:f2} leva!");
                    break;
                }

                AllProducts++;
                totalSum += price;
                text = Console.ReadLine();
            }

            if (text == "Stop")
            {
                Console.WriteLine($"You bought {AllProducts} products for {totalSum:f2} leva.");
            }

        }
    }
}
