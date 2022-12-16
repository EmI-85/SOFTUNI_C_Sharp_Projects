using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = "";

            while((destination = Console.ReadLine()) != "End" )
            {
                double destinationPrice = double.Parse(Console.ReadLine());

                double savedMoney = 0;

                while(destinationPrice > savedMoney)
                {
                    savedMoney += double.Parse(Console.ReadLine());
                }

                Console.WriteLine($"Going to {destination}!");

            }


        }
    }
}
