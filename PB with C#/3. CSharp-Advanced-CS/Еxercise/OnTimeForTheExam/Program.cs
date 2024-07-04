using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMin = int.Parse(Console.ReadLine());

            int examTimeAsMinutes = examHour * 60 + examMin;
            int arrivalTimeAsMinutes = arrivalHour * 60 + arrivalMin;

            int differenceExamArrival = examTimeAsMinutes - arrivalTimeAsMinutes;
            int differenceHours = differenceExamArrival / 60;
            int differenceMinutes = differenceExamArrival % 60;

            if (differenceExamArrival == 0)
            {
                Console.WriteLine("On time");
            }
            else if (differenceExamArrival > 0)
            {
                if(differenceExamArrival <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{differenceMinutes} minutes before the start");
                }
                else 
                {
                    Console.WriteLine("Early");
                    if(differenceHours <= 0)
                    {
                        Console.WriteLine($"{differenceMinutes} minutes before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{differenceHours}:{differenceMinutes:d2} hours before the start");
                    }
                }
            }
            else if (differenceExamArrival < 0)
            {
                int differenceExamArrivalLate = arrivalTimeAsMinutes - examTimeAsMinutes;
                int differenceHoursLate = Math.Abs(differenceExamArrival / 60);
                int differenceMinutesLate = Math.Abs(differenceExamArrival % 60);
                
                Console.WriteLine("Late");

                    if (differenceHoursLate <= 0)
                    {
                        Console.WriteLine($"{differenceMinutesLate} minutes after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{differenceHoursLate}:{differenceMinutesLate:d2} hours after the start");
                    }
            }

        }
    }
}
