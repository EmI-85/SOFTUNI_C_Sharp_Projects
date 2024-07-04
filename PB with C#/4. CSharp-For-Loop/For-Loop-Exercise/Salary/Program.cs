using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOpenTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfOpenTabs; i++)
            {
                string websiteName = Console.ReadLine();

                if (websiteName == "Facebook")
                {
                    salary -= 150;

                    if (salary <= 0)
                    {
                        Console.WriteLine($"You have lost your salary.");
                        return;
                    }
                }

                if (websiteName == "Instagram")
                {
                    salary -= 100;

                    if (salary <= 0)
                    {
                        Console.WriteLine($"You have lost your salary.");
                        return;
                    }
                }

                if (websiteName == "Reddit")
                {
                    salary -= 50;

                    if (salary <= 0)
                    {
                        Console.WriteLine($"You have lost your salary.");
                        return;
                    }
                }
            }

            if (salary <= 0)
            {
                Console.WriteLine($"You have lost your salary.");

            }
            else
            {
                Console.WriteLine($"{salary}");
            }
        }
    }
}



 