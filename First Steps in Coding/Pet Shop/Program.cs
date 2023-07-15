using System;

namespace Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfFoodForDogs=int.Parse(Console.ReadLine());
            int numberOfFoodForCats=int.Parse(Console.ReadLine());
            double totalSum = numberOfFoodForDogs * 2.50 + numberOfFoodForCats * 4;
            Console.WriteLine($"{totalSum} lv.");
            
        }
    }
}
