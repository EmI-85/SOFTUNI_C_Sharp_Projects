using System;

namespace MovieRating
{
    class Program
    {
        static void Main(string[] args)
        {
            int movieNum = int.Parse(Console.ReadLine());
            double maxRating = double.MinValue;
            double minRating = double.MaxValue;
            string maxRatingName = "";
            string minRatingName = "";
            double ratingSum = 0;

            for (int i = 1; i <= movieNum; i++)
            {
                string movieName = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());

                if(rating > maxRating)
                {
                    maxRatingName = movieName;
                    maxRating = rating;
                }
                else if(rating < minRating)
                {
                    minRatingName = movieName;
                    minRating = rating;
                }
                ratingSum += rating;
            }

            double average = ratingSum / movieNum;


            Console.WriteLine($"{maxRatingName} is with highest rating: {maxRating:f1}");
            Console.WriteLine($"{minRatingName} is with lowest rating: {minRating:f1}");
            Console.WriteLine($"Average rating: {average:f1}");
        }
    }
}
