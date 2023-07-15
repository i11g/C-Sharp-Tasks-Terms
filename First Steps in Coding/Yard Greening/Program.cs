using System;

namespace Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sqmeters=double.Parse(Console.ReadLine());
            double price = sqmeters * 7.61;
            double discount = price * 0.18;
            double totalprice=price-discount;
            Console.WriteLine($"The final price is: {totalprice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
