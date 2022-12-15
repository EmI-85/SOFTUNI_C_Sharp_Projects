using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPoorGrades = int.Parse(Console.ReadLine());

            int poorGradesCounter = 0;
            int numberOfProblems = 0;
            int sumOfGrades = 0;
            string lastProblemName = "";
            bool hasFailed = true;

            while (poorGradesCounter < numberOfPoorGrades)
            {
                string problemName = Console.ReadLine();
                
                if(problemName == "Enough")
                {
                    hasFailed = false;
                    break;
                }

                int grade = int.Parse(Console.ReadLine());

                if(grade <= 4)
                {
                    poorGradesCounter++;
                }

                sumOfGrades += grade;
                numberOfProblems++;
                lastProblemName = problemName;
            }

            if(hasFailed)
            {
                Console.WriteLine($"You need a break, {poorGradesCounter} poor grades.");
            }
            else
            {
            Console.WriteLine($"Average score: {(sumOfGrades / (double)numberOfProblems):f2}");
            Console.WriteLine($"Number of problems: {numberOfProblems}");
            Console.WriteLine($"Last problem: {lastProblemName}");
            }
        }
    }
}
