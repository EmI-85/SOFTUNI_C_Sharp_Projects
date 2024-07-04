using System;

namespace TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupsNumber = int.Parse(Console.ReadLine());
            
            double numberOfPeopleTrekking = 0;
            int numberOfPeopleMusala = 0;
            int numberOfPeopleMonblan = 0;
            int numberOfPeopleKilimandjaro = 0;
            int numberOfPeopleK2 = 0;
            int numberOfPeopleEverest= 0;

            for (int i = 1; i <= groupsNumber; i++)
            {
                int numberOfPeopleInGroup = int.Parse(Console.ReadLine());

                numberOfPeopleTrekking += numberOfPeopleInGroup;

                if(numberOfPeopleInGroup <= 5)
                {
                    numberOfPeopleMusala += numberOfPeopleInGroup;
                }
                else if (numberOfPeopleInGroup > 5 && numberOfPeopleInGroup <= 12)
                {
                    numberOfPeopleMonblan += numberOfPeopleInGroup;
                }
                else if (numberOfPeopleInGroup > 12 && numberOfPeopleInGroup <= 25)
                {
                    numberOfPeopleKilimandjaro += numberOfPeopleInGroup;
                }
                else if (numberOfPeopleInGroup > 25 && numberOfPeopleInGroup <= 40)
                {
                    numberOfPeopleK2 += numberOfPeopleInGroup;
                }
                else if (numberOfPeopleInGroup > 40)
                {
                    numberOfPeopleEverest += numberOfPeopleInGroup;
                }
            }
                
                double percentageMusala = numberOfPeopleMusala / numberOfPeopleTrekking * 100;
                double percentageMonblan = numberOfPeopleMonblan / numberOfPeopleTrekking * 100;
                double percentageKilimandjaro = numberOfPeopleKilimandjaro / numberOfPeopleTrekking * 100;
                double percentageK2 = numberOfPeopleK2 / numberOfPeopleTrekking * 100;
                double percentageEverest = numberOfPeopleEverest / numberOfPeopleTrekking * 100;

                Console.WriteLine($"{percentageMusala:f2}%");
                Console.WriteLine($"{percentageMonblan:f2}%");
                Console.WriteLine($"{percentageKilimandjaro:f2}%");
                Console.WriteLine($"{percentageK2:f2}%");
                Console.WriteLine($"{percentageEverest:f2}%");
           
        }
    }
}
