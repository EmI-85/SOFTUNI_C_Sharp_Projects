using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            double grade5_6 = 0;
            double grade4_5 = 0;
            double grade3_4 = 0;
            double grade3orBelow = 0;
            double gradesSum = 0;

            for (int i = 1; i <= numberOfStudents; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if(grade < 3)
                {
                    grade3orBelow++;
                    gradesSum += grade;
                }
                else if (grade >= 3 && grade <= 3.99)
                {
                    grade3_4++;
                    gradesSum += grade;
                }
                else if (grade >= 4 && grade <= 4.99)
                {
                    grade4_5++;
                    gradesSum += grade;
                }
                else if (grade >= 5 && grade <= 6)
                {
                    grade5_6++;
                    gradesSum += grade;
                }
            }

            double average = gradesSum / numberOfStudents;
            double percentagebelow3 = grade3orBelow / numberOfStudents * 100;
            double percentage3_4 = grade3_4 / numberOfStudents * 100;
            double percentage4_5 = grade4_5 / numberOfStudents * 100;
            double percentage5_6 = grade5_6 / numberOfStudents * 100;

            Console.WriteLine($"Top students: {percentage5_6:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {percentage4_5:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {percentage3_4:f2}%");
            Console.WriteLine($"Fail: {percentagebelow3:f2}%");
            Console.WriteLine($"Average: {average:f2}");

        }
    }
}
