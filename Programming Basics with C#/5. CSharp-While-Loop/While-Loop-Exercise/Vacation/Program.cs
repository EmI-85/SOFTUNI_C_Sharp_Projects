using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeededForVacation = double.Parse(Console.ReadLine());
            double moneyOwned = double.Parse(Console.ReadLine());

            int daysCounter = 0;
            int spendingCounter = 0;


            while(moneyOwned < moneyNeededForVacation && spendingCounter < 5)
            { 
            string typeOfAction = Console.ReadLine();
            double actionAmount = double.Parse(Console.ReadLine());
            daysCounter++;

                if(typeOfAction == "spend")
                {
                    moneyOwned -= actionAmount;
                    spendingCounter++;

                    if(moneyOwned <= 0)
                    {
                        moneyOwned = 0;
                    }
                }
                else if(typeOfAction == "save")
                {
                    moneyOwned += actionAmount;
                    spendingCounter = 0;
                }
            }

            if(spendingCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
            }

            if(moneyOwned >= moneyNeededForVacation)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }


        }
    }
}
