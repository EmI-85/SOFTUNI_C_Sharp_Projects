using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            double grades = 0;
            bool hasFailed = false;
            bool hasGraduated = true;
            int year = 1;

            while(year <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                
                if(grade < 4)
                {
                    if(hasFailed)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {year} grade");
                        hasGraduated = false;
                        break;
                    }

                    hasFailed = true;
                    continue;   
                }
                
                grades += grade;
                year++;
            }

            if(hasGraduated)
            { 
                Console.WriteLine($"{studentName} graduated. Average grade: {(grades / 12):f2}");
            }

        }
    }
}
