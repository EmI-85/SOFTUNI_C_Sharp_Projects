using System;

namespace _06.MultiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            char first = number[2];
            char second = number[1];
            char third = number[0];

            int firstNum = int.Parse(first.ToString());
            int secondNum = int.Parse(second.ToString());
            int thirdNum = int.Parse(third.ToString());


            for (int a = 1; a <= firstNum; a++)
            {
                for (int b = 1; b <= secondNum; b++)
                {
                    for (int c = 1; c <= thirdNum; c++)
                    {
                        double result = a * b * c;
                        Console.WriteLine($"{a} * {b} * {c} = {result};");
                    }
                }

            }

            // 100/100

            

        }
    }
}
