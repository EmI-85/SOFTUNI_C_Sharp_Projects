using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            double numSum = 0;
            int counter = 0;

            for(int i = 1; i <= n ; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                numSum += currentNum;
                counter++;
            }

            double average = numSum / counter;

            Console.WriteLine($"{average:f2}");
        }
    }
}
