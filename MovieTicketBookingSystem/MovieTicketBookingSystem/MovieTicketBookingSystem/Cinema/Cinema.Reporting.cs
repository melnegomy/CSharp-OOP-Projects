using MovieTicketBookingSystem.Class;
using System;
using System.Collections.Generic;
using System.Text;


namespace MovieTicketBookingSystem.Class
{
    partial class Cinema
    {
        public void PrintAllTickets()
        {
            Console.WriteLine();
            Console.WriteLine("--- All Tickets (from Cinema.Reporting) ---");

            foreach (Ticket t in tickets)
            {
                if (t != null)
                {
                    t.Print();
                }
            }
        }
    }
}
