using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerNumber = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double roseStandardPrice = 5.00;
            double dahliaStandardPrice = 3.80;
            double tulipStandardPrice = 2.80;
            double narcissStandardPrice = 3.00;
            double gladiolusStandardPrice = 2.50;
            double flowersCost = 0;

            switch(flowerType)
            {
                case "Roses":
                    if(flowerNumber > 80)
                    {
                    flowersCost = flowerNumber * roseStandardPrice * 0.9;
                    }
                    else
                    {
                    flowersCost = flowerNumber * roseStandardPrice;
                    }
                    break;
                case "Dahlias":
                    if(flowerNumber > 90)
                    {
                        flowersCost = flowerNumber * dahliaStandardPrice * 0.85;
                    }
                    else
                    {
                        flowersCost = flowerNumber * dahliaStandardPrice;
                    }
                    break;
                case "Tulips":
                    if (flowerNumber > 80)
                    {
                        flowersCost = flowerNumber * tulipStandardPrice * 0.85;
                    }
                    else
                    {
                        flowersCost = flowerNumber * tulipStandardPrice;
                    }
                    break;
                case "Narcissus":
                    if (flowerNumber < 120)
                    {
                        flowersCost = flowerNumber * narcissStandardPrice * 1.15;
                    }
                    else
                    {
                        flowersCost = flowerNumber * narcissStandardPrice;
                    }
                    break;
                case "Gladiolus":
                    if (flowerNumber < 80)
                    {
                        flowersCost = flowerNumber * gladiolusStandardPrice * 1.20;
                    }
                    else
                    {
                        flowersCost = flowerNumber * gladiolusStandardPrice;
                    }
                    break;
            }

            if(budget >= flowersCost)
            {
                double moneyLeft = budget - flowersCost;
                Console.WriteLine($"Hey, you have a great garden with {flowerNumber} {flowerType} and {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = flowersCost - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.");
            }
           
        }
    }
}
