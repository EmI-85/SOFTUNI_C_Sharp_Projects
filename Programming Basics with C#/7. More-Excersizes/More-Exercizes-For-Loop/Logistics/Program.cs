using System;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfItems = int.Parse(Console.ReadLine());
            double allitems = 0;
            double itemsMicrobus = 0;
            double itemsTruck = 0;
            double itemsTrain = 0;

            for (int i = 1; i <= numberOfItems; i++)
            {
                int tons = int.Parse(Console.ReadLine());

                if (tons <= 3)
                {
                    allitems += tons;
                    itemsMicrobus += tons;
                }
                else if (tons >= 4 && tons <= 11)
                {
                    allitems += tons;
                    itemsTruck += tons;
                }
                else if (tons >= 12)
                {
                    allitems += tons;
                    itemsTrain += tons;
                }

            }

            double priceMicrobus = itemsMicrobus * 200;
            double priceTruck = itemsTruck * 175;
            double priceTrain = itemsTrain * 120;

            double averagePrice = Math.Round(((priceMicrobus + priceTruck + priceTrain) / allitems), 2);
            double percentageMicrobus = itemsMicrobus / allitems * 100;
            double percentageTruck = itemsTruck / allitems * 100;
            double percentageTrain = itemsTrain / allitems * 100;

            Console.WriteLine($"{averagePrice:f2}");
            Console.WriteLine($"{percentageMicrobus:f2}%");
            Console.WriteLine($"{percentageTruck:f2}%");
            Console.WriteLine($"{percentageTrain:f2}%");

        }
    }
}
