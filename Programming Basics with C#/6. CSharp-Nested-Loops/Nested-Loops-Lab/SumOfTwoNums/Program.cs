using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowerBound = int.Parse(Console.ReadLine());
            int upperBound = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int combination = 0;
            bool isMagicNumberFound = false;

            for(int i = lowerBound; i <= upperBound; i++)
            {
                for (int j = lowerBound; j <= upperBound; j++)
                {
                    combination++;

                    if(i + j == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combination} ({i} + {j} = {magicNumber})");
                        isMagicNumberFound = true;
                        break;
                    } 
                }

                if (isMagicNumberFound)
                {
                    break;
                }
            }

            if(!isMagicNumberFound)
            {
                Console.WriteLine($"{combination} combinations - neither equals {magicNumber}");
            }
            

        }
    }
}
