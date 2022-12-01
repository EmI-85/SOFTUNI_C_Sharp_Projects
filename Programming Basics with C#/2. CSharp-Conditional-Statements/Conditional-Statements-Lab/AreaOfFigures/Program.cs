using System;

namespace AreaOfFigures
{
    class Program
    {
        private static double side1;

        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            double area = 0;
            if (figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = side * side;
            }
            else if (figureType == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                area = sideA * sideB;
            }
            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * radius * radius;
            }
            else if (figureType == "triangle")
            {
                double sideM = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                area = sideM * h / 2;
            }
            Console.WriteLine("{0:0.000}", area);
        }
    }
}
