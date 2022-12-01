using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            int videoCards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ramMemoryCard = int.Parse(Console.ReadLine());

            double videoCardPrice = 250;
            double videoCardsBill = videoCardPrice * videoCards;
            double processorPrice = 0.35 * videoCardsBill;
            double ramMemoryCardPrice = 0.10 * videoCardsBill;

            double totalBill = videoCardsBill + processors * processorPrice + ramMemoryCard * ramMemoryCardPrice;
            double discount = 0;
           
            if (videoCards > processors)
            {
                discount = 0.15 * totalBill;
             }
            
            double finalPrice = totalBill - discount;
            double remainingBudget = budget - finalPrice;
            double moneyShortage = Math.Abs(finalPrice - budget);

            if (budget >= totalBill)
            { 
            Console.WriteLine($"You have {remainingBudget:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {moneyShortage:f2} leva more!");
            }
            
        }
    }
}
