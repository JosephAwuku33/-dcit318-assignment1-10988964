using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter their age
            Console.Write("Please enter your age: ");
            string input = Console.ReadLine() ?? "";

            // Parse the input to an integer
            if (int.TryParse(input, out int age))
            {
                // Calculate the ticket price based on the age
                decimal ticketPrice = CalculateTicketPrice(age);

                // Display the ticket price
                Console.WriteLine($"The ticket price for age {age} is: GHS{ticketPrice}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }

        static decimal CalculateTicketPrice(int age)
        {
            // Standard ticket price
            decimal standardPrice = 10m;
            // Discounted ticket price
            decimal discountedPrice = 7m;

            // Determine the ticket price based on the age
            if (age <= 12 || age >= 65)
            {
                return discountedPrice;
            }
            else
            {
                return standardPrice;
            }
        }
    }
}
