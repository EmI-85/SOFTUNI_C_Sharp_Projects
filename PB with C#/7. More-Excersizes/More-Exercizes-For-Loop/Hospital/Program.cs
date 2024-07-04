using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            

            int numberOfDoctors = 7;
            int treatedPatients = 0;
            int unTreatedPatients = 0;
            

           for (int i = 1; i <= period; i++)
                {
                int numberOfIncomingPatients = int.Parse(Console.ReadLine());

                if (i % 3 == 0 && treatedPatients < unTreatedPatients)
                {
                    numberOfDoctors++;
                }

                if (numberOfIncomingPatients > numberOfDoctors)
                    {
                    unTreatedPatients += (numberOfIncomingPatients - numberOfDoctors);
                    treatedPatients += numberOfDoctors;
                    }
                    else
                    {
                    treatedPatients += numberOfIncomingPatients;
                    }
           }
              
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {unTreatedPatients}.");
        }
    }
}

