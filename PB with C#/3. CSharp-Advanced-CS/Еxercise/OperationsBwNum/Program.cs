using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            double result = 0;
            string finalResult = null;

            switch (symbol)
            {
                case'+':
                    result = number1 + number2;
                    if(result % 2 == 0)
                    {
                        finalResult = $"{number1} {symbol} {number2} = {result} - even";
                    }
                    else
                    {
                        finalResult = $"{number1} {symbol} {number2} = {result} - odd";
                    }
                    break;
                case '-':
                    result = number1 - number2;
                    if (result % 2 == 0)
                    {
                        finalResult = $"{number1} {symbol} {number2} = {result} - even";
                    }
                    else
                    {
                        finalResult = $"{number1} {symbol} {number2} = {result} - odd";
                    }
                    break;
                case '*':
                    result = number1 * number2;
                    if (result % 2 == 0)
                    {
                        finalResult = $"{number1} {symbol} {number2} = {result} - even";
                    }
                    else
                    {
                        finalResult = $"{number1} {symbol} {number2} = {result} - odd";
                    }
                    break;
                case '/':
                    if(number2 == 0)
                    {
                        finalResult = $"Cannot divide {number1} by zero";
                    }
                    else
                    {
                        result = number1 / (double)number2;
                        finalResult = $"{number1} {symbol} {number2} = {result:f2}";
                    }
                    break;
                case '%':
                    if (number2 == 0)
                    {
                        finalResult = $"Cannot divide {number1} by zero";
                    }
                    else
                    {
                        result = number1 % number2;
                        finalResult = $"{number1} {symbol} {number2} = {result}";
                    }
                    break;
            }
            Console.WriteLine(finalResult);

        }
    }
}
