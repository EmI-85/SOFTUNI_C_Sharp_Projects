using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue;

            while(true)
            {
                string input = Console.ReadLine();

                if(input == "Stop")
                {
                    break;
                }

                int currentNumber = int.Parse(input);
                
                if(currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }
            }

            Console.WriteLine(maxNumber);

        }
    }
}
