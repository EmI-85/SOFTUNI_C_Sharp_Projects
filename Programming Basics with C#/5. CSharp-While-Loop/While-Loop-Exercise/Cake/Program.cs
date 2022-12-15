using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int cakeArea = width * length;
            string command = "";

            bool cakeIsFinished = false;

            while(true)
            {
                command = Console.ReadLine();

                if(command == "STOP")
                {
                    break;
                }

               int pieces = int.Parse(command);

                cakeArea -= pieces;

                if (cakeArea <= 0)
                {
                    cakeIsFinished = true;
                    break;
                }
            }

            if(cakeIsFinished)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakeArea)} pieces more.");
            }
            else
            {
                Console.WriteLine($"{cakeArea} pieces are left.");
            }

        }
    }
}
