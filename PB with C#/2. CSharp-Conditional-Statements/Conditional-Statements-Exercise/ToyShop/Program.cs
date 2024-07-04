using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            int numberOfPuzzles = int.Parse(Console.ReadLine());
            int numberOfDolls = int.Parse(Console.ReadLine());
            int numberOfTeddyBears = int.Parse(Console.ReadLine());
            int numberOfMinions = int.Parse(Console.ReadLine());
            int numberOfTrucks = int.Parse(Console.ReadLine());

            double pricePuzzles = 2.60;
            double priceDolls = 3.00;
            double priceTeddyBears = 4.10;
            double priceMinions = 8.20;
            double priceTrucks = 2.00;

            double totalRevenue = numberOfPuzzles * pricePuzzles + numberOfDolls * priceDolls +
                numberOfTeddyBears * priceTeddyBears + numberOfMinions * priceMinions +
                numberOfTrucks * priceTrucks;
                       
            int numberOfOrderedItems = numberOfPuzzles + numberOfDolls + numberOfTeddyBears +
                numberOfMinions + numberOfTrucks;

            double discount = 0;

            if (numberOfOrderedItems >= 50)
            {
                discount = 0.25 * totalRevenue; 
            }
            else if (numberOfOrderedItems < 50)
            {
                discount = 0;
            }

            double earnedMoney = totalRevenue - discount;
            double rent = 0.10 * earnedMoney;
            double profit = earnedMoney - rent;
            double residualProfit = profit - vacationPrice;

            if (profit >= vacationPrice)
            {
                 Console.WriteLine($"Yes! {residualProfit:f2} lv left.");
            }
           else
            {
                double moneyNeeded = vacationPrice - profit;
                Console.WriteLine($"Not enough money! {moneyNeeded:f2} lv needed.");
            }

        }
    }
}
