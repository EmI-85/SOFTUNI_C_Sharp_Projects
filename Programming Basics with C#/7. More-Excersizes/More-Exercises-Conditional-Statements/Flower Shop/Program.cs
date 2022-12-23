using System;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMagnolias = int.Parse(Console.ReadLine());
            int numberOfHyacinths = int.Parse(Console.ReadLine());
            int numberOfRoses = int.Parse(Console.ReadLine());
            int numberOfCactuses = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double priceOfMagnolias = 3.25;
            double priceOfHyacinths = 4.00;
            double priceOfRoses = 3.50;
            double priceOfCactuses = 8.00;

            double flowersRevenue = (numberOfMagnolias * priceOfMagnolias + numberOfCactuses * priceOfCactuses +
                numberOfHyacinths * priceOfHyacinths + numberOfRoses * priceOfRoses) * 0.95;

            if (flowersRevenue >= giftPrice)
            {
                double moneyLeft = Math.Floor(flowersRevenue - giftPrice);
                Console.WriteLine($"She is left with {moneyLeft} leva.");
            }
            else
            {
                double moneyShortage = Math.Ceiling(giftPrice - flowersRevenue);
                Console.WriteLine($"She will have to borrow {moneyShortage} leva.");
            }
        }
    }
}
