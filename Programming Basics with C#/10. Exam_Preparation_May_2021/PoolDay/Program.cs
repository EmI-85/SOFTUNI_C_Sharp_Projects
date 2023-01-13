using System;

namespace HighJump
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetHeight = int.Parse(Console.ReadLine());

            int attemptsCounter = 0;
            bool hasFailed = false;
            int failsCounter = 0;
            int currentLevel = 0;


            while(targetHeight < currentLevel)
            {
                currentLevel = targetHeight - 30;

                int currentAttemptScore = int.Parse(Console.ReadLine());
                attemptsCounter++;

                while (currentAttemptScore < currentLevel)
                {
                     failsCounter++;

                        if(failsCounter == 3)
                        {
                            hasFailed = true;
                            break;
                        }
                    }

                    currentLevel += 5;
                    currentAttemptScore = Console.ReadLine();
                }

                if (hasFailed)
                {
                    break;
                }

            }

            if (currentLevel >= targetHeight)
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {currentLevel}cm after {attemptsCounter} jumps.");
            }
            else
            {
                Console.WriteLine($"Tihomir failed at {currentLevel}cm after {attemptsCounter} jumps.");
            }


        }
    }
}
