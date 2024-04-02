using System;

namespace _13._Continue_Sum
{
    class Program
    {
        static void Main()
        {
            // Sum numbers from 1 to 9 that are not divisors of 3
            int sum = 0;
            for (int i = 1; i < 10; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }

                sum += i;
                Console.WriteLine(i);
            }

            Console.WriteLine($"sum = {sum}");
        }
    }
}
