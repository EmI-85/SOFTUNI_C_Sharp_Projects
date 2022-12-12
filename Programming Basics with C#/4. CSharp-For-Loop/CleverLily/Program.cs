using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentAge = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int toysNum = 0;
            double cashBox = 0;
            double moneyGift = 10;

            for(int birthday = 1; birthday <= currentAge; birthday++)
            {
                int remainder = birthday % 2;
                bool isOdd = remainder == 1;

                if(isOdd)
                {
                    toysNum++;
                }
                else
                {
                    cashBox += moneyGift;
                    cashBox--;
                    moneyGift += 10;
                }
            }

            double totalToys = toyPrice * toysNum;
            double totalFromBirthdays = totalToys + cashBox;

            if(totalFromBirthdays >= washingMachinePrice)
            {
                double moneyLeft = totalFromBirthdays - washingMachinePrice;
                Console.WriteLine($"Yes! {moneyLeft:f2}");
            }
            else
            {
                double moneyNeeded = washingMachinePrice - totalFromBirthdays;
                Console.WriteLine($"No! {moneyNeeded:f2}");
            }


        }
    }
}
