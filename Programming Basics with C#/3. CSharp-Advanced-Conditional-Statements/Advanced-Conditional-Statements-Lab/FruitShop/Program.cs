using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;
            
            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.50;
                        double totalRevenueBananas = quantity * price;
                        Console.WriteLine($"{totalRevenueBananas:f2}");
                        break;
                    case "apple":
                        price = 1.20;
                        double totalRevenueApples = quantity * price;
                        Console.WriteLine($"{totalRevenueApples:f2}");
                        break;
                    case "orange":
                        price = 0.85;
                        double totalRevenueOranges = quantity * price;
                        Console.WriteLine($"{totalRevenueOranges:f2}");
                        break;
                    case "grapefruit":
                        price = 1.45;
                        double totalRevenueGrapefruits = quantity * price;
                        Console.WriteLine($"{totalRevenueGrapefruits:f2}");
                        break;
                    case "kiwi":
                        price = 2.70;
                        double totalRevenueKiwis = quantity * price;
                        Console.WriteLine($"{totalRevenueKiwis:f2}");
                        break;
                    case "pineapple":
                        price = 5.50;
                        double totalRevenuePineaplles = quantity * price;
                        Console.WriteLine($"{totalRevenuePineaplles:f2}");
                        break;
                    case "grapes":
                        price = 3.85;
                        double totalRevenueGrapes = quantity * price;
                        Console.WriteLine($"{totalRevenueGrapes:f2}");
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.70;
                        double totalRevenueBananas = quantity * price;
                        Console.WriteLine($"{totalRevenueBananas:f2}");
                        break;
                    case "apple":
                        price = 1.25;
                        double totalRevenueApples = quantity * price;
                        Console.WriteLine($"{totalRevenueApples:f2}");
                        break;
                    case "orange":
                        price = 0.90;
                        double totalRevenueOranges = quantity * price;
                        Console.WriteLine($"{totalRevenueOranges:f2}");
                        break;
                    case "grapefruit":
                        price = 1.60;
                        double totalRevenueGrapefruits = quantity * price;
                        Console.WriteLine($"{totalRevenueGrapefruits:f2}");
                        break;
                    case "kiwi":
                        price = 3.00;
                        double totalRevenueKiwis = quantity * price;
                        Console.WriteLine($"{totalRevenueKiwis:f2}");
                        break;
                    case "pineapple":
                        price = 5.60;
                        double totalRevenuePineaplles = quantity * price;
                        Console.WriteLine($"{totalRevenuePineaplles:f2}");
                        break;
                    case "grapes":
                        price = 4.20;
                        double totalRevenueGrapes = quantity * price;
                        Console.WriteLine($"{totalRevenueGrapes:f2}");
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }
            }

            else
            {
                Console.WriteLine("error");
            }

            


        }
    }
}
