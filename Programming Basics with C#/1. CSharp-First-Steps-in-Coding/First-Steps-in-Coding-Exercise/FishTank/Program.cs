using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentagenotavailable = double.Parse(Console.ReadLine())/100;
            double waterliter = 10 * 100;
            double tankvolume = length * width * height;
            double tankvolumeinliters = tankvolume / waterliter;
            double neededliters = tankvolumeinliters * (1- percentagenotavailable);
            Console.WriteLine(neededliters);
            }
    }
}
