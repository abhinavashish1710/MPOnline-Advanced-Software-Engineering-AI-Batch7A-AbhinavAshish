using System;

namespace Assignment6_CabBooking
{
    class Program
    {
        static void BookCab(string location)
        {
            if (string.IsNullOrWhiteSpace(location))
            {
                throw new ArgumentException("Pickup location cannot be empty.");
            }

            if (location.ToLower() == "unknown")
            {
                throw new Exception("GPS service failed.");
            }

            Console.WriteLine("Cab booked successfully!");
            Console.WriteLine("Pickup Location: " + location);
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter Pickup Location: ");
                string location = Console.ReadLine();

                BookCab(location);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Invalid Location: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}