using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sumEven = 0;
            int sumOdd = 0;

            for(int i = 1; i < n; i++)
            {
                if(i % 2 == 0)
                {
                    int currentNumber = int.Parse(Console.ReadLine());
                    sumEven += currentNumber;
                }
                else
                {
                    int currentNumber = int.Parse(Console.ReadLine());
                    sumOdd += currentNumber;
                }
            }

            if(sumEven == sumOdd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumEven}");
            }
            else 
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumEven-sumOdd)}");
            }
        }
    }
}
