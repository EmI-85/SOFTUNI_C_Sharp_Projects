using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            int bookNum = 0;
            bool isBookFound = false;

            string selectedBookName = Console.ReadLine();

            while (selectedBookName != "No More Books!")
            {
                selectedBookName = Console.ReadLine();

                if (selectedBookName == favouriteBook)
                {
                    isBookFound = true;
                    break;
                }
                
                bookNum++;
                
            }

            if (isBookFound)
            {
                Console.WriteLine($"You checked {bookNum} books and found it.");
            }
            else
            {
                    Console.WriteLine($"The book you search is not here!");
                    Console.WriteLine($"You checked {bookNum} books.");
            }

        }
    }
}
