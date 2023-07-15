using System;

namespace Project_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name=Console.ReadLine();
            int projectsNumber=int.Parse(Console.ReadLine());

            Console.WriteLine($"The architect {name} will need {projectsNumber * 3} hours to complete {projectsNumber} project/s.");
        }
    }
}
