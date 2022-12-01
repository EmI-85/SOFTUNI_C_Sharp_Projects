using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int depositTerm = int.Parse(Console.ReadLine());
            double annualInterest = double.Parse(Console.ReadLine());
            double percentageDivider = 100;
            int monthsInYear = 12;
            double annualInterestPercentage = annualInterest / percentageDivider;

            double finalAmount = deposit + depositTerm * ((deposit * annualInterestPercentage) /monthsInYear);

            Console.WriteLine(finalAmount);

        }
    }
}
