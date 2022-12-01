using System;

namespace Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());

            int timeInFifteen = mins + 15;

            if (timeInFifteen > 59)
            {
                hours++;

                if(hours > 23)
                {
                    hours = 0;
                }
                timeInFifteen = timeInFifteen - 60;
            }
            Console.WriteLine($"{hours}:{timeInFifteen:D2}");
        }
    }
}
