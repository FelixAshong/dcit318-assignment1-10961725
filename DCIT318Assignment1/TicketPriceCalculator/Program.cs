using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            string? input = Console.ReadLine();

            if (input != null && int.TryParse(input, out int age))
            {
                int ticketPrice = (age <= 12 || age >= 65) ? 7 : 10;
                Console.WriteLine($"The ticket price is: GHC{ticketPrice}");

            }
            else
            {

                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }
    }
}
