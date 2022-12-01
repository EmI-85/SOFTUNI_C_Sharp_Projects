using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            double chickenMenuPrice = 10.35;
            double fishMenuPrice = 12.40;
            double vegetarianMenuPrice = 8.15;
            double dessertPercentage = 0.20;
            double deliveryPrice = 2.50;


            int numberOfChickenMenus = int.Parse(Console.ReadLine());
            int numberOfFishMenus = int.Parse(Console.ReadLine());
            int numberOfVegetarianMenus = int.Parse(Console.ReadLine());

            double chickenTotal = numberOfChickenMenus * chickenMenuPrice;
            double fishTotal = numberOfFishMenus * fishMenuPrice;
            double vegetarianTotal = numberOfVegetarianMenus * vegetarianMenuPrice;

            double menusTotal = chickenTotal + fishTotal + vegetarianTotal;
            double dessertPrice = menusTotal * dessertPercentage;
            double FoodTotal = menusTotal + dessertPrice;

            double orderTotal = FoodTotal + deliveryPrice;

            Console.WriteLine(orderTotal);

        }
    }
}
