using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double initialPoints = double.Parse(Console.ReadLine());
            int jurymembersNum = int.Parse(Console.ReadLine());

            bool pointsEnoughForNomination = false;

            double totalPoints = initialPoints;

            for(int juryMember = 1; juryMember <= jurymembersNum; juryMember++)
            {
                string juryMemberName = Console.ReadLine();
                double juryMemberPoints = double.Parse(Console.ReadLine());

                double pointsFromJuryMember = juryMemberName.Length * juryMemberPoints / 2;

                totalPoints += pointsFromJuryMember;

                if(totalPoints > 1250.5)
                {
                    pointsEnoughForNomination = true;
                    break; 
                }
            }

            if (pointsEnoughForNomination)
                {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totalPoints:f1}!");
                }
            else
                {
                double pointsNeeded = 1250.5 - totalPoints;
                Console.WriteLine($"Sorry, {actorName} you need {pointsNeeded:f1} more!");
                }

        }
    }
}
