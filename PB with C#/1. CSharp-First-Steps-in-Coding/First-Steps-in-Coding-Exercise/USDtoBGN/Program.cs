using System;

namespace USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double currencyrate = 1.79549;
            double USDquantity = double.Parse(Console.ReadLine());
            double conversionvalue = USDquantity * currencyrate;
            Console.WriteLine(conversionvalue);
        }
    }
}
