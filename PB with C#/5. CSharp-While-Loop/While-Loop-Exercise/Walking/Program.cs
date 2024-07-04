using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int dailyStepsGoal = 10000;
            int totalSteps = 0;
            string command = "";

            while(totalSteps < dailyStepsGoal)
            {
                command = Console.ReadLine();

                if(command == "Going home")
                {
                    int lastSteps = int.Parse(Console.ReadLine());
                    totalSteps += lastSteps;
                    break;
                }

                int steps = int.Parse(command);
                totalSteps += steps;
            }

            if(totalSteps >= dailyStepsGoal)
            {
                Console.WriteLine($"Goal reached! Good job!");

                int stepsMoreThanGoal = totalSteps - dailyStepsGoal;
                Console.WriteLine($"{stepsMoreThanGoal} steps over the goal!");
            }
            else
            {
                int stepsLess = dailyStepsGoal - totalSteps;
                Console.WriteLine($"{stepsLess} more steps to reach goal.");
            }

        }

    }
}
