using System;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());

            double allElectricity = 0;
            double allWater = 0;
            double allInternet = 0;
            double allMisc = 0;

            for (int i = 1; i <= months; i++)
            {
                double electricityBill = double.Parse(Console.ReadLine());

                allElectricity += electricityBill;
                allWater += 20;
                allInternet += 15;
                allMisc += 1.20 * (electricityBill + 20 + 15);
            }

            double average = (allElectricity + allWater + allInternet + allMisc) / (double)months;

            Console.WriteLine($"Electricity: {allElectricity:f2} lv");
            Console.WriteLine($"Water: {allWater:f2} lv");
            Console.WriteLine($"Internet: {allInternet:f2} lv");
            Console.WriteLine($"Other: {allMisc:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");

        }
    }
}
