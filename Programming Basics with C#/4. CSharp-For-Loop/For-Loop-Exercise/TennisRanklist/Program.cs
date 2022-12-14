using System;

namespace TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamentsNum = int.Parse(Console.ReadLine());
            int initialPoints = int.Parse(Console.ReadLine());
            double tournamentPoints = 0;
            int numberOfWins = 0;

            for(int i = 1; i <= tournamentsNum; i++)
            {
                string stageReached = Console.ReadLine();

                switch (stageReached)
                {
                    case "W":
                        tournamentPoints += 2000;
                        numberOfWins++;
                        break;
                    case "F":
                        tournamentPoints += 1200;
                        break;
                    case "SF":
                        tournamentPoints += 720;
                        break;
                }
            }

            double totalPoints = initialPoints + tournamentPoints;
            Console.WriteLine($"Final points: {totalPoints}");

            double averageTournamentPoints = Math.Floor(tournamentPoints / tournamentsNum);
            Console.WriteLine($"Average points: {averageTournamentPoints}");

            double percentageWins = (numberOfWins / (double)tournamentsNum) * 100;

            Console.WriteLine($"{percentageWins:f2}%");
        }
    }
}
