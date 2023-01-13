using System;

namespace TournamentOfChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamentDays = int.Parse(Console.ReadLine());
            int wonCounter = 0;
            int lostCounter = 0;
            double moneyWonDay = 0;
            double moneyWonTotal = 0;
            int winnerForTheDay = 0;

            for (int i = 1; i <= tournamentDays; i++)
            {
                while(true)
                {
                    string command = Console.ReadLine();

                    if (command == "Finish")
                    {
                        break;
                    }

                    string result = Console.ReadLine();
                    if (result == "win")
                    {
                        wonCounter++;
                        moneyWonDay += 20;
                    }
                    else if(result == "lose")
                    {
                        lostCounter ++;
                        moneyWonDay += 0;
                    }
                    
                }

                if (wonCounter > lostCounter)
                {
                    moneyWonDay += 0.10 * moneyWonDay;
                    winnerForTheDay++;
                }
                moneyWonTotal += moneyWonDay;
                wonCounter = 0;
                lostCounter = 0;
                moneyWonDay = 0;
            }

            if (winnerForTheDay >= 0.50 * tournamentDays)
            {
                moneyWonTotal += 0.20 * moneyWonTotal;
                Console.WriteLine($"You won the tournament! Total raised money: {moneyWonTotal:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {moneyWonTotal:f2}");
            }
           
        }
    }
}
