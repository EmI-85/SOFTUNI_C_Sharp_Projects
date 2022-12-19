using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentTicketsSold = 0;
            int standardTicketsSold = 0;
            int kidTicketsSold = 0;
            int totalTicketsSold = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Finish")
                {
                    break;
                }

                string filmTitle = input;
                int seatsAvailable = int.Parse(Console.ReadLine());
                int ticketsSoldForFilm = 0;

                while(ticketsSoldForFilm < seatsAvailable)
                {
                    string ticketType = Console.ReadLine();

                    if(ticketType == "End")
                    {
                        break;
                    }

                    ticketsSoldForFilm++;
                    totalTicketsSold++;

                    if (ticketType == "student")
                    {
                        studentTicketsSold++;
                    }
                    else if (ticketType == "standard")
                    {
                        standardTicketsSold++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidTicketsSold++;
                    }

                }

                double percentageFull = ticketsSoldForFilm / (seatsAvailable * 1.00) * 100;
                Console.WriteLine($"{filmTitle} - {percentageFull:f2}% full.");
            }

            Console.WriteLine($"Total tickets: {totalTicketsSold}");

            double percentageStudentTickets = studentTicketsSold / (totalTicketsSold * 1.00) * 100;
            Console.WriteLine($"{percentageStudentTickets:f2}% student tickets.");

            double percentageStandardTickets = standardTicketsSold / (totalTicketsSold * 1.00) * 100;
            Console.WriteLine($"{percentageStandardTickets:f2}% standard tickets.");

            double percentageKidTickets = kidTicketsSold / (totalTicketsSold * 1.00) * 100;
            Console.WriteLine($"{percentageKidTickets:f2}% kids tickets.");

        }
    }
}
