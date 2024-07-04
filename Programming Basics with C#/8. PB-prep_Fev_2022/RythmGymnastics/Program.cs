using System;

namespace RythmGymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string type = Console.ReadLine();

            double gradeDifficulty = 0;
            double gradePerformance = 0;

            if(country == "Russia")
            {
                if(type == "ribbon")
                {
                    gradeDifficulty = 9.100;
                    gradePerformance = 9.400;

                }
                else if (type == "hoop")
                {
                    gradeDifficulty = 9.300;
                    gradePerformance = 9.800;
                }
                else if (type == "rope")
                {
                    gradeDifficulty = 9.600;
                    gradePerformance = 9.000;
                }

            }
            else if(country == "Bulgaria")
            {
                if (type == "ribbon")
                {
                    gradeDifficulty = 9.600;
                    gradePerformance = 9.400;

                }
                else if (type == "hoop")
                {
                    gradeDifficulty = 9.550;
                    gradePerformance = 9.750;
                }
                else if (type == "rope")
                {
                    gradeDifficulty = 9.500;
                    gradePerformance = 9.400;
                }

            }
            else if(country == "Italy")
            {
                if (type == "ribbon")
                {
                    gradeDifficulty = 9.200;
                    gradePerformance = 9.500;

                }
                else if (type == "hoop")
                {
                    gradeDifficulty = 9.450;
                    gradePerformance = 9.350;
                }
                else if (type == "rope")
                {
                    gradeDifficulty = 9.700;
                    gradePerformance = 9.150;
                }

            }

            double totalGrade = gradeDifficulty + gradePerformance;
            double percentageToMax = ((20 - totalGrade) / 20) * 100;

            Console.WriteLine($"The team of {country} get {totalGrade:f3} on {type}.");
            Console.WriteLine($"{percentageToMax:f2}%");


        }
    }
}
