using System;

namespace projectCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            int neededHours = projects * 3;

            Console.WriteLine($"The architect {architectName} will need {neededHours} hours to complete {projects} project/s.");
        }
    }
}

