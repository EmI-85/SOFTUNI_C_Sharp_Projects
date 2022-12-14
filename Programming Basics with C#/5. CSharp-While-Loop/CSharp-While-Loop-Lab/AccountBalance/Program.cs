using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double balance = 0;

            while(true)
            {
                string input = Console.ReadLine();
                
                if (input == "NoMoreMoney")
                {
                    break;
                }

                double money = double.Parse(input);

                if (money < 0)
                {
                    Console.WriteLine($"Invalid operation!");
                    break;
                }
                
                balance += money;
                Console.WriteLine($"Increase: {money:f2}");
            }

            Console.WriteLine($"Total: {balance:f2}");

        }
    }
}
