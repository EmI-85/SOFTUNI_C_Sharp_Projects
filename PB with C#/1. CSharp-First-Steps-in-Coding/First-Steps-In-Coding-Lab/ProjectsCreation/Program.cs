using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numberofprojects = int.Parse(Console.ReadLine());
            int hours = numberofprojects * 3;
            Console.WriteLine($"The architect" +" " +name+ " "+"will need" + " " + hours + " "+"hours to complete" + " " + numberofprojects + " " + "project/s.");
        }
    }
}
