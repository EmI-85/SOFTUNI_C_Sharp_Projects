using System;

namespace HighJump2
{
    class Program
    {
        static void Main(string[] args)
        {
             
            int goal = int.Parse(Console.ReadLine());

            int start = goal - 30;
            int countOfTotalJumps = 0;
            int countOfUnsuccessfulJumps = 0;

            while (start <= goal)
            {
                int currentJump = int.Parse(Console.ReadLine());

                while (currentJump <= start)
                {
                    countOfTotalJumps++;

                    countOfUnsuccessfulJumps++;

                    if (countOfUnsuccessfulJumps == 3)
                    {
                        Console.WriteLine($"Tihomir failed at {start}cm after {countOfTotalJumps} jumps.");
                        return;
                    }

                    currentJump = int.Parse(Console.ReadLine());
                }

                countOfTotalJumps++;

                countOfUnsuccessfulJumps = 0;

                start += 5;
            }

            Console.WriteLine($"Tihomir succeeded, he jumped over {goal}cm after {countOfTotalJumps} jumps.");
        
    }
    }
}
