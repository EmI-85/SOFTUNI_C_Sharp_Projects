using System;

namespace PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {

            int poolVolumeInLiters = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double timeToFillPool = poolVolumeInLiters / (p1 + p2);
            double p1Contribution = p1 * hours;
            double p2Contribution = p2 * hours;

            double waterVolume = p1Contribution + p2Contribution;
            var percentageFull = (waterVolume / poolVolumeInLiters) * 100;
            double p1percentage = p1Contribution / waterVolume * 100;
            double p2percentage = p2Contribution / waterVolume * 100;
            double overflow = waterVolume - poolVolumeInLiters;

            if (poolVolumeInLiters >= waterVolume)
            {
                Console.WriteLine($"The pool is {percentageFull:f2}% full. Pipe 1: {p1percentage:f2}% . Pipe 2: {p2percentage:f2}%.");
            }
            else if (poolVolumeInLiters < waterVolume)
            {
                Console.WriteLine($"For {hours} hours the pool overflows with {overflow} liters.");
            }
            
            
        }
    }
}
