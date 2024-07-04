using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysStay = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string feedback = Console.ReadLine();

            int nightsStay = daysStay - 1;
            double roomForOnePersonPrice = 18;
            double apartmentPrice = 25;
            double presidentApartmentPrice = 35;
            double priceForStay = 0;

            if(typeOfRoom == "room for one person")
            {
                if(feedback == "positive")
                {
                priceForStay = nightsStay * roomForOnePersonPrice * 1.25;
                Console.WriteLine($"{priceForStay:f2}");
                }
                else if (feedback == "negative")
                {
                    priceForStay = nightsStay * roomForOnePersonPrice * 0.90;
                    Console.WriteLine($"{priceForStay:f2}");
                }
            }
            else if(typeOfRoom == "apartment")
            {
                if (feedback == "positive")
                {
                    if(daysStay < 10)
                    {
                        priceForStay = (nightsStay * apartmentPrice * 0.70) * 1.25;
                        Console.WriteLine($"{priceForStay:f2}");
                    }
                    else if (daysStay >= 10 && daysStay <= 15)
                    {
                        priceForStay = (nightsStay * apartmentPrice * 0.65) * 1.25;
                        Console.WriteLine($"{priceForStay:f2}");
                    }
                    else if (daysStay > 15)
                    {
                        priceForStay = (nightsStay * apartmentPrice * 0.50) * 1.25;
                        Console.WriteLine($"{priceForStay:f2}");
                    }
                }
                else if (feedback == "negative")
                {
                    if (daysStay < 10)
                    {
                        priceForStay = (nightsStay * apartmentPrice * 0.70) * 0.9;
                        Console.WriteLine($"{priceForStay:f2}");
                    }
                    else if (daysStay >= 10 && daysStay <= 15)
                    {
                        priceForStay = (nightsStay * apartmentPrice * 0.65) * 0.9;
                        Console.WriteLine($"{priceForStay:f2}");
                    }
                    else if (daysStay > 15)
                    {
                        priceForStay = (nightsStay * apartmentPrice * 0.50) * 0.9;
                        Console.WriteLine($"{priceForStay:f2}");
                    }
                }

            }
            else if(typeOfRoom == "president apartment")
            {
                if (feedback == "positive")
                {
                    if (daysStay < 10)
                    {
                        priceForStay = (nightsStay * presidentApartmentPrice * 0.90) * 1.25;
                        Console.WriteLine($"{priceForStay:f2}");
                    }
                    else if (daysStay >= 10 && daysStay <= 15)
                    {
                        priceForStay = (nightsStay * presidentApartmentPrice * 0.85) * 1.25;
                        Console.WriteLine($"{priceForStay:f2}");
                    }
                    else if (daysStay > 15)
                    {
                        priceForStay = (nightsStay * presidentApartmentPrice * 0.80) * 1.25;
                        Console.WriteLine($"{priceForStay:f2}");
                    }
                }
                else if (feedback == "negative")
                {
                    if (daysStay < 10)
                    {
                        priceForStay = (nightsStay * presidentApartmentPrice * 0.90) * 0.9;
                        Console.WriteLine($"{priceForStay:f2}");
                    }
                    else if (daysStay >= 10 && daysStay <= 15)
                    {
                        priceForStay = (nightsStay * presidentApartmentPrice * 0.85) * 0.9;
                        Console.WriteLine($"{priceForStay:f2}");
                    }
                    else if (daysStay > 15)
                    {
                        priceForStay = (nightsStay * presidentApartmentPrice * 0.80) * 0.9;
                        Console.WriteLine($"{priceForStay:f2}");
                    }
                }
            }
        }
    }
}
