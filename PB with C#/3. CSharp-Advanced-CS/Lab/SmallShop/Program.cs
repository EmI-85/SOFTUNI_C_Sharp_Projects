using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            if (town == "Sofia")
            {
                {
                    if (product == "coffee")
                    {
                        price = 0.50;
                        double billTotal = quantity * price;
                        Console.WriteLine(billTotal);
                    }
                    else if(product == "water")
                    {
                        price = 0.80;
                        double billTotal = quantity * price;
                        Console.WriteLine(billTotal);
                    }
                    else if (product == "beer")
                    {
                        price = 1.20;
                        double billTotal = quantity * price;
                        Console.WriteLine(billTotal);
                    }
                    else if (product == "sweets")
                    {
                        price = 1.45;
                        double billTotal = quantity * price;
                        Console.WriteLine(billTotal);
                    }
                    else if (product == "peanuts")
                    {
                        price = 1.60;
                        double billTotal = quantity * price;
                        Console.WriteLine(billTotal);
                    }
                }
            }
            else if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    price = 0.40;
                    double billTotal = quantity * price;
                    Console.WriteLine(billTotal);
                }
                else if (product == "water")
                {
                    price = 0.70;
                    double billTotal = quantity * price;
                    Console.WriteLine(billTotal);
                }
                else if (product == "beer")
                {
                    price = 1.15;
                    double billTotal = quantity * price;
                    Console.WriteLine(billTotal);
                }
                else if (product == "sweets")
                {
                    price = 1.30;
                    double billTotal = quantity * price;
                    Console.WriteLine(billTotal);
                }
                else if (product == "peanuts")
                {
                    price = 1.50;
                    double billTotal = quantity * price;
                    Console.WriteLine(billTotal);
                }
            }
            else if (town == "Varna")
            {
                if (product == "coffee")
                {
                    price = 0.45;
                    double billTotal = quantity * price;
                    Console.WriteLine(billTotal);
                }
                else if (product == "water")
                {
                    price = 0.70;
                    double billTotal = quantity * price;
                    Console.WriteLine(billTotal);
                }
                else if (product == "beer")
                {
                    price = 1.10;
                    double billTotal = quantity * price;
                    Console.WriteLine(billTotal);
                }
                else if (product == "sweets")
                {
                    price = 1.35;
                    double billTotal = quantity * price;
                    Console.WriteLine(billTotal);
                }
                else if (product == "peanuts")
                {
                    price = 1.55;
                    double billTotal = quantity * price;
                    Console.WriteLine(billTotal);
                }
            }
        }
    }
}
