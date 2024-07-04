using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricepersqm = 7.61;
            double discountpercentage = 0.18;
            double sqmforgreening = double.Parse(Console.ReadLine());
            double totalprice = sqmforgreening * pricepersqm;
            double discountedprice = totalprice * (1 - discountpercentage);
            double discountamount = totalprice * discountpercentage;
            Console.WriteLine("The final price is:" + " " + discountedprice + " " + "lv.");
            Console.WriteLine("The discount is:" + " " + discountamount + " " + "lv.");
            }
    }
}
