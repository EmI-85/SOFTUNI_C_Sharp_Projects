using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
           int baseNumber = int.Parse(Console.ReadLine());
            double bonusPoints = 0.0;
            
            if (baseNumber <= 100)
            {
                bonusPoints = 5;
            }
            else if (baseNumber >= 1000)
            {
                bonusPoints = 0.10 * baseNumber;
            }
            else
            {
                bonusPoints = 0.20 * baseNumber;
            }
            
            if (baseNumber % 2 == 0)
            {
                bonusPoints = bonusPoints +1;
            }
            else if (baseNumber % 10 == 5)
            {
                bonusPoints = bonusPoints + 2;
            }
            Console.WriteLine(bonusPoints);
            Console.WriteLine(baseNumber + bonusPoints);
        }
    }
}
