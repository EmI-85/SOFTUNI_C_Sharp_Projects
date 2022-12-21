using System;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double BglEurRate = 1.94;
            double vegetablePrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            int vegetablesKg = int.Parse(Console.ReadLine());
            int fruitsKg = int.Parse(Console.ReadLine());

            double totalPriceinBgl = vegetablePrice * vegetablesKg + fruitPrice*fruitsKg;
            double totalPriceinEur = totalPriceinBgl / BglEurRate;

            Console.WriteLine("{0:0.00}", totalPriceinEur);
        }
    }
}
