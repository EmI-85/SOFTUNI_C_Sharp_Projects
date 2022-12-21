using System;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double trainingLabWidthWithoutCorridor = h - 1;

            double deskSize = 0.70;
            double deskSizeWidth = 1.20;
            double numberOfDesksPerRow = Math.Floor(trainingLabWidthWithoutCorridor/deskSize);
            double numberOfRows = Math.Floor(w/deskSizeWidth);
            double numberOfSeats = numberOfDesksPerRow * numberOfRows - 3;

            Console.WriteLine(numberOfSeats);
        }
    }
}
