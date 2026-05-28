
// =================================================================
// ============== Movie Ticket Booking System ====================
// =================================================================
using MovieTicketBookingSystem.Extensions;

namespace MovieTicketBookingSystem.Class
{
    class Program
    {
        static void Main()
        {
            Cinema cinema = new Cinema("Galaxy");
            cinema.OpenCinema();

            Ticket t1 =
                new StandardTicket(
                    "Inception",
                    80,
                    "A5");

            Ticket t2 =
                new VIPTicket(
                    "Avengers",
                    200,
                    true);

            Ticket t3 =
                new IMAXTicket(
                    "Dune",
                    100,
                    true);

            t1.Book();
            t2.Book();
            t3.Book();

            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);

            cinema.PrintAllTickets();

            Console.WriteLine();
            Console.WriteLine("--- Polymorphism: Final Price per Ticket ---");
            Ticket[] arr = { t1, t2, t3 };


            foreach (Ticket t in arr)
            {
                Console.WriteLine(
                $"{t.GetType().Name}" +
                $" => Final Price: " +
                $"{t.CalculateFinalPrice():F2}"
                );
            }

            Console.WriteLine();
            Console.WriteLine("--- Extension Method: Receipt ---");
            Console.WriteLine(t2.GenerateReceipt());
            Console.WriteLine();
            Console.WriteLine("--- Extension Method: Total Revenue ---");
            Console.WriteLine($"Total Revenue: {arr.TotalRevenue():F2}");


            cinema.CloseCinema();
        }
    }
}