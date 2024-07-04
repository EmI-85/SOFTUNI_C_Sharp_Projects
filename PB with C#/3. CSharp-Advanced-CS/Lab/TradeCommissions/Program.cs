using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commissionPercentage = 0;

                switch (town)
                {
                case "Sofia":
                    if(sales >= 0 && sales <= 500)
                    {
                        commissionPercentage = 0.05;
                        double commissionAmount = sales * commissionPercentage;
                        Console.WriteLine($"{commissionAmount:f2}");
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commissionPercentage = 0.07;
                        double commissionAmount = sales * commissionPercentage;
                        Console.WriteLine($"{commissionAmount:f2}");
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        commissionPercentage = 0.08;
                        double commissionAmount = sales * commissionPercentage;
                        Console.WriteLine($"{commissionAmount:f2}");
                    }
                    else if (sales > 10000)
                    {
                        commissionPercentage = 0.12;
                        double commissionAmount = sales * commissionPercentage;
                        Console.WriteLine($"{commissionAmount:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                case "Varna":
                    if (sales >= 0 && sales <= 500)
                    {
                        commissionPercentage = 0.045;
                        double commissionAmount = sales * commissionPercentage;
                        Console.WriteLine($"{commissionAmount:f2}");
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commissionPercentage = 0.075;
                        double commissionAmount = sales * commissionPercentage;
                        Console.WriteLine($"{commissionAmount:f2}");
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        commissionPercentage = 0.10;
                        double commissionAmount = sales * commissionPercentage;
                        Console.WriteLine($"{commissionAmount:f2}");
                    }
                    else if (sales > 10000)
                    {
                        commissionPercentage = 0.13;
                        double commissionAmount = sales * commissionPercentage;
                        Console.WriteLine($"{commissionAmount:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                case "Plovdiv":
                    if (sales >= 0 && sales <= 500)
                    {
                        commissionPercentage = 0.055;
                        double commissionAmount = sales * commissionPercentage;
                        Console.WriteLine($"{commissionAmount:f2}");
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commissionPercentage = 0.08;
                        double commissionAmount = sales * commissionPercentage;
                        Console.WriteLine($"{commissionAmount:f2}");
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        commissionPercentage = 0.12;
                        double commissionAmount = sales * commissionPercentage;
                        Console.WriteLine($"{commissionAmount:f2}");
                    }
                    else if (sales > 10000)
                    {
                        commissionPercentage = 0.145;
                        double commissionAmount = sales * commissionPercentage;
                        Console.WriteLine($"{commissionAmount:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                default:
                    Console.WriteLine("error");
                    break;
            }

        }
    }
}
