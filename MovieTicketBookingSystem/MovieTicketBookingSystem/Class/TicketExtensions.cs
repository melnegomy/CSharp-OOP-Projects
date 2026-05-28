using System;
using System.Collections.Generic;
using System.Text;

namespace MovieTicketBookingSystem.Class
{
    static class TicketExtensions
    {
        public static string GenerateReceipt(
            this Ticket t)
        {
            return

    $@"========== RECEIPT ==========
Movie    : {t.MovieName}
Type     : {t.GetType().Name}
Price    : {t.Price}
Final    : {t.CalculateFinalPrice():F2}
Status   : {(t.IsBooked ? "Booked" : "Not Booked")}
=============================";

        }



        public static decimal TotalRevenue(
            this Ticket[] tickets)
        {
            decimal total = 0;

            foreach (Ticket t in tickets)
            {
                if (t != null)
                {
                    total +=
                        t.CalculateFinalPrice();
                }
            }

            return total;
        }
    }
}
