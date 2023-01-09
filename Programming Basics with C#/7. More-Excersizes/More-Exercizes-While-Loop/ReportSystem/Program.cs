using System;

namespace ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int moneyNeeded = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int moneyCollectedCard = 0;
            int moneyCollectedCash = 0;
            int transactionCounter = 0;
            int transactionCard = 0;
            int transactionCash = 0;

            if (command == "End")
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
            
                while (command != "End")
                {
                    int itemPrice = int.Parse(command);

                    if (transactionCounter % 2 > 0)
                    {
                        if (itemPrice > 100)
                        {
                            Console.WriteLine("Error in transaction!");
                         continue;
                        }
                        else
                        {
                            moneyCollectedCash += itemPrice;
                            Console.WriteLine("Product sold!");
                            transactionCash++;
                        }
                    }
                    else if (transactionCounter % 2 == 0)
                    {
                        if (itemPrice < 10)
                        {
                            Console.WriteLine("Error in transaction!");
                            continue;
                        }
                        else
                        {
                            moneyCollectedCard += itemPrice;
                            Console.WriteLine("Product sold!");
                            transactionCard++;
                        }
                    }
                    
                    command = Console.ReadLine();
                    transactionCounter++;
            }

                int moneyCollectedTotal = moneyCollectedCard + moneyCollectedCash;
                double averageCash = moneyCollectedCash / (double)transactionCash;
                double averageCard = moneyCollectedCard / (double)transactionCard;

                if (moneyCollectedTotal >= moneyNeeded)
                {
                    Console.WriteLine($"Average CS: {averageCash:f2}");
                    Console.WriteLine($"Average CC: {averageCard:f2}");
                }
                else
                {
                    Console.WriteLine("Failed to collect required money for charity.");
                }
        }
    }
}
