using System;

namespace FuelTank2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuelQuantity = double.Parse(Console.ReadLine());
            string cardOwner = Console.ReadLine();

            double gasolinePrice = 2.22;
            double dieselPrice = 2.33;
            double gasPrice = 0.93;

            double gasolineDiscountPerLiter = 0.18;
            double dieselDiscountPerLiter = 0.12;
            double gasDiscountPerLiter = 0.08;

            double percentageDiscount20To25Liters = 0.08;
            double percentageDiscountOver25Liters = 0.10;


            if (fuelType == "Gasoline")
            {
                double gasolineTotal = fuelQuantity * gasolinePrice;

                if (fuelQuantity >= 20 && fuelQuantity <= 25)
                {
                    if (cardOwner == "Yes")
                    {
                        gasolineTotal = fuelQuantity * (gasolinePrice - gasolineDiscountPerLiter);
                        double gasolineolineFinal = gasolineTotal - percentageDiscount20To25Liters * gasolineTotal;
                        Console.WriteLine($"{gasolineolineFinal:f2} lv.");
                    }
                    else
                    {
                        gasolineTotal = gasolineTotal - (percentageDiscount20To25Liters * gasolineTotal);
                        Console.WriteLine($"{gasolineTotal:f2} lv.");
                    }
                }
                else if (fuelQuantity > 25)
                {
                    if (cardOwner == "Yes")
                    {
                        gasolineTotal = fuelQuantity * (gasolinePrice - gasolineDiscountPerLiter);
                        double gasolineFinal = gasolineTotal - percentageDiscountOver25Liters * gasolineTotal;
                        Console.WriteLine($"{gasolineFinal:f2} lv.");
                    }
                    else
                    {
                        gasolineTotal = gasolineTotal - (percentageDiscountOver25Liters * gasolineTotal);
                        Console.WriteLine($"{gasolineTotal:f2} lv.");
                    }
                }
                else
                {
                    Console.WriteLine($"{gasolineTotal:f2} lv.");
                }
            }

            if (fuelType == "Diesel")
            {
                double dieselTotal = fuelQuantity * dieselPrice;

                if (fuelQuantity >= 20 && fuelQuantity <= 25)
                {
                    if (cardOwner == "Yes")
                    {
                        dieselTotal = fuelQuantity * (dieselPrice - dieselDiscountPerLiter);
                        double dieselFinal = dieselTotal - percentageDiscount20To25Liters * dieselTotal;
                        Console.WriteLine($"{dieselFinal:f2} lv.");
                    }
                    else
                    {
                        dieselTotal = dieselTotal - (percentageDiscount20To25Liters * dieselTotal);
                        Console.WriteLine($"{dieselTotal:f2} lv.");
                    }
                }
                else if (fuelQuantity > 25)
                {
                    if (cardOwner == "Yes")
                    {
                        dieselTotal = fuelQuantity * (dieselPrice - dieselDiscountPerLiter);
                        double dieselFinal = dieselTotal - percentageDiscountOver25Liters * dieselTotal;
                        Console.WriteLine($"{dieselFinal:f2} lv.");
                    }
                    else
                    {
                        dieselTotal = dieselTotal - (percentageDiscountOver25Liters * dieselTotal);
                        Console.WriteLine($"{dieselTotal:f2} lv.");
                    }
                }
                else
                {
                    Console.WriteLine($"{dieselTotal:f2} lv.");
                }
            }

            if (fuelType == "Gas")
            {
                double gasTotal = fuelQuantity * gasPrice;

                if (fuelQuantity >= 20 && fuelQuantity <= 25)
                {
                    if (cardOwner == "Yes")
                    {
                        gasTotal = fuelQuantity * (gasPrice - gasDiscountPerLiter);
                        double gasFinal = gasTotal - percentageDiscount20To25Liters * gasTotal;
                        Console.WriteLine($"{gasFinal:f2} lv.");
                    }
                    else
                    {
                        gasTotal = gasTotal - (percentageDiscount20To25Liters * gasTotal);
                        Console.WriteLine($"{gasTotal:f2} lv.");
                    }
                }
                else if (fuelQuantity > 25)
                {
                    if (cardOwner == "Yes")
                    {
                        gasTotal = fuelQuantity * (gasPrice - gasDiscountPerLiter);
                        double gasFinal = gasTotal - percentageDiscountOver25Liters * gasTotal;
                        Console.WriteLine($"{gasFinal:f2} lv.");
                    }
                    else
                    {
                        gasTotal = gasTotal - (percentageDiscountOver25Liters * gasTotal);
                        Console.WriteLine($"{gasTotal:f2} lv.");
                    }
                }
                else
                {
                    Console.WriteLine($"{gasTotal:f2} lv.");
                }
            }




        }
    }
}
