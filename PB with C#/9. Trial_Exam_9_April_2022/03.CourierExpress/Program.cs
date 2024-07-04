using System;

namespace _03.CourierExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            double packageWeight = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int distanceInKm = int.Parse(Console.ReadLine());

            double finalPrice = 0;

            if(type == "standard")
            {
                if(packageWeight < 1)
                {
                    finalPrice = 0.03 * distanceInKm;
                }
                else if(packageWeight >= 1 && packageWeight < 10)
                {
                    finalPrice = 0.05 * distanceInKm;
                }
                else if(packageWeight >= 10 && packageWeight < 40)
                {
                    finalPrice = 0.10 * distanceInKm;
                }
                else if (packageWeight >= 40 && packageWeight < 90)
                {
                    finalPrice = 0.15 * distanceInKm;
                }
                else if(packageWeight >= 90 && packageWeight < 150)
                {
                    finalPrice = 0.20 * distanceInKm;
                }
            }
            else if(type == "express")
            {
                if (packageWeight < 1)
                {
                    finalPrice = 0.03 * distanceInKm + (0.03 * 0.80 * packageWeight) * distanceInKm; ;
                }
                else if (packageWeight >= 1 && packageWeight < 10)
                {
                    finalPrice = 0.05 * distanceInKm + (0.05 * 0.40 * packageWeight) * distanceInKm; ;
                }
                else if (packageWeight >= 10 && packageWeight < 40)
                {
                    finalPrice = 0.10 * distanceInKm + (0.10 * 0.05 * packageWeight) * distanceInKm; ;
                }
                else if (packageWeight >= 40 && packageWeight < 90)
                {
                    finalPrice = 0.15 * distanceInKm + (0.15 * 0.02 * packageWeight) * distanceInKm;
                }
                else if (packageWeight >= 90 && packageWeight < 150)
                {
                    finalPrice = 0.20 * distanceInKm + (0.20 * 0.01 * packageWeight) * distanceInKm;
                }
            }

            Console.WriteLine($"The delivery of your shipment with weight of {packageWeight:f3} kg. would cost {finalPrice:f2} lv.");

            // 100/100
        }
    }
}
