using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juryMembersNum = int.Parse(Console.ReadLine());

            double totalAverageGrades = 0;
            int presentationsCounter = 0;
            
            while(true)
            {
                string input = Console.ReadLine();

                if(input == "Finish")
                {
                    break;
                }

                string presentationTitle = input;
                double gradesForPresentation = 0;

                presentationsCounter++;

                for (int i = 1; i <= juryMembersNum; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    gradesForPresentation += grade;
                }

                double averageGradeFromPresentation = gradesForPresentation / juryMembersNum;
                Console.WriteLine($"{presentationTitle} - {averageGradeFromPresentation:f2}.");

                totalAverageGrades += averageGradeFromPresentation;
            }

            double averageFromCourse = totalAverageGrades / presentationsCounter;
            Console.WriteLine($"Student's final assessment is {averageFromCourse:f2}.");

        }
    }
}
