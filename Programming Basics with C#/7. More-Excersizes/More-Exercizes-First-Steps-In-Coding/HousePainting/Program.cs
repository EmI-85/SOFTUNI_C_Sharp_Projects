using System;

namespace HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double greenPaint = 3.4;
            double redPaint = 4.3;

            double frontAndBackWallsArea = 2 * (x * x);
            double sideWallsArea = 2 * (x * y);

            double doorHeight = 2;
            double doorWidth = 1.2;
            double doorArea = doorHeight * doorWidth;

            double windowHeight = 1.5;
            double windowArea = windowHeight * windowHeight;

            double wallsArea = (frontAndBackWallsArea - doorArea) + sideWallsArea - (2 * windowArea);
            
            double litersGreenPaint = wallsArea / greenPaint;

            double roofArea = 2 * (x * y) + 2 * ((h * x) / 2);

            double litersRedPaint = roofArea / redPaint;

            Console.WriteLine($"{litersGreenPaint:f2}");
            Console.WriteLine($"{litersRedPaint:f2}");
        }
    }
}
