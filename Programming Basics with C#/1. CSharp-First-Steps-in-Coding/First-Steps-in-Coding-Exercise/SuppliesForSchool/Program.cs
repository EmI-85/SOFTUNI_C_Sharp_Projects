using System;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            double penPricePerPackage = 5.80;
            double markerPricePerpackage = 7.20;
            double cleanerPricePerLiter = 1.20;

            int pensNeeded = int.Parse(Console.ReadLine());
            int markersNeeded = int.Parse(Console.ReadLine());
            int cleanerNeeded = int.Parse(Console.ReadLine());
            double discountPercentage = double.Parse(Console.ReadLine());

            double pensTotal = penPricePerPackage * pensNeeded;
            double markersTotal = markerPricePerpackage * markersNeeded;
            double cleanerTotal = cleanerPricePerLiter * cleanerNeeded;
            double totalMaterials = pensTotal + markersTotal + cleanerTotal;
            int percentageDivider = 100;
            double discountAmount = totalMaterials * (discountPercentage / percentageDivider);
            double finalTotal = totalMaterials - discountAmount;

            Console.WriteLine(finalTotal);
        }
    }
}
