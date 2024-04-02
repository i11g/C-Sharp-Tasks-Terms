using System;

namespace _14._TriangleOfStars
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 0; row < n; row++)
            {
                for (int star = 0; star < n; star++)
                {
                    Console.Write("*");
                    if (star == row)
                    {
                        break; 
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
