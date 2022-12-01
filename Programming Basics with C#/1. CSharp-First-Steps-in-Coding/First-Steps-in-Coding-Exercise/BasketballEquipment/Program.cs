using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int annualTrainingFee = int.Parse(Console.ReadLine());
            double shoesPrice = annualTrainingFee - 0.4 * annualTrainingFee;
            double jerseyPrice = shoesPrice - 0.2* shoesPrice;
            double ballPrice = jerseyPrice * 1/4;
            double accessoriesPrice = ballPrice * 1/5;
            double totalCosts = annualTrainingFee + shoesPrice + jerseyPrice + ballPrice + accessoriesPrice;
            Console.WriteLine(totalCosts);
        }
    }
}
