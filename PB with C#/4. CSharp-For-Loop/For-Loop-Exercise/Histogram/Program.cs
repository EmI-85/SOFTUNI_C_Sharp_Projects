using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int between1And199 = 0;
            int between200And399 = 0; 
            int between400And599 = 0; 
            int between600And799 = 0;
            int between800And1000 = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if(num >= 1 && num <= 199 )
                {
                    between1And199++;
                }
                else if (num >= 200 && num <= 399)
                {
                    between200And399++;
                }
                else if (num >= 400 && num <= 599)
                {
                    between400And599++;
                }
                else if (num >= 600 && num <= 799)
                {
                    between600And799++;
                }
                else if (num >= 800 && num <= 1000)
                {
                    between800And1000++;
                }
            }

            double percentage1to199 = between1And199 / (double)n * 100;
            double percentage200to399 = between200And399 / (double)n * 100;
            double percentage400to599 = between400And599 / (double)n * 100;
            double percentage600to799 = between600And799 / (double)n * 100;
            double percentage800to1000 = between800And1000 / (double)n * 100;

            Console.WriteLine($"{percentage1to199:f2}%");
            Console.WriteLine($"{percentage200to399:f2}%");
            Console.WriteLine($"{percentage400to599:f2}%");
            Console.WriteLine($"{percentage600to799:f2}%");
            Console.WriteLine($"{percentage800to1000:f2}%");

        }
    }
}
