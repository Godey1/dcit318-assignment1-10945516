using System;

namespace MovieTheater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            string input = Console.ReadLine();
            int age;

            // Validate the input
            if (int.TryParse(input, out age) && age >= 0)
            {
                double ticketPrice = CalculateTicketPrice(age);
                Console.WriteLine($"The ticket price for age {age} is: GHC{ticketPrice}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }

        static double CalculateTicketPrice(int age)
        {
            if (age <= 12 || age >= 65)
            {
                return 7.00;
            }
            else
            {
                return 10.00;
            }
        }
    }
}

