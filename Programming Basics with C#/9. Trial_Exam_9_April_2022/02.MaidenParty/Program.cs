using System;

namespace _02.MaidenParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double partyCost = double.Parse(Console.ReadLine());
            int loveLettersNum = int.Parse(Console.ReadLine());
            int rosesNum = int.Parse(Console.ReadLine());
            int keyChainsNum = int.Parse(Console.ReadLine());
            int sketchesNum = int.Parse(Console.ReadLine());
            int goodLuckSurprisesNum = int.Parse(Console.ReadLine());

            double loveLetterPrice = 0.60;
            double rosePrice = 7.20;
            double keyChainsPrice = 3.60;
            double sketchPrice = 18.20;
            double goodLuckSurprisePrice = 22;

            double grossRevenue = loveLetterPrice * loveLettersNum + rosePrice * rosesNum +
                keyChainsPrice * keyChainsNum + sketchPrice * sketchesNum + goodLuckSurprisePrice * goodLuckSurprisesNum;

            double itemsCount = loveLettersNum + rosesNum + keyChainsNum + sketchesNum + goodLuckSurprisesNum;
            
                if(itemsCount > 25)
                {
                grossRevenue = grossRevenue * 0.65;
                }

            double netRevenue = grossRevenue * 0.90;

            if(netRevenue >= partyCost)
            {
                double moneyLeft = netRevenue - partyCost;
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else
            {
                double moneyNeeded = partyCost - netRevenue;
                Console.WriteLine($"Not enough money! {moneyNeeded:f2} lv needed.");
            }

            // 100/100
        }
    }
}
