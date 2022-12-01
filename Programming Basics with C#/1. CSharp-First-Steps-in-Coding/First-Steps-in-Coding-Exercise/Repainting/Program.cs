using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double nylonPricePerSqM = 1.50;
            double paintPricePerLiter = 14.50;
            double thinnerPricePerLiter = 5;
            double plasticBagsPrice = 0.40;

            int nylonNeededSqM = int.Parse(Console.ReadLine());
            int paintNeededInLiters = int.Parse(Console.ReadLine());
            int thinnerNeeded = int.Parse(Console.ReadLine());
            int workersHours = int.Parse(Console.ReadLine());
            int additionalNylonSqM = 2;
            int totalNylonSqM = nylonNeededSqM + additionalNylonSqM;
            double totalPaintInLiters = paintNeededInLiters * 1.1;
            double thirtyPercent = 0.3;
            double totalSpendOnNylon = totalNylonSqM * nylonPricePerSqM;
            double totalSpendOnPaint = totalPaintInLiters * paintPricePerLiter;
            double totalThinner = thinnerNeeded * thinnerPricePerLiter;

            double totalMaterials = totalSpendOnNylon + totalSpendOnPaint + totalThinner + plasticBagsPrice;
            double workersHourlyFee = thirtyPercent * totalMaterials;
            double totalForWorkers = workersHours * workersHourlyFee;

            double totalForRepainting = totalMaterials + totalForWorkers;
            Console.WriteLine(totalForRepainting);

        }
    }
}
