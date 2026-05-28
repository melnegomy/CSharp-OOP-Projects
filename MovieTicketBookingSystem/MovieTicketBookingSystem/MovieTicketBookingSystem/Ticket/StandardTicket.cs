using System;
using System.Collections.Generic;
using System.Text;

namespace MovieTicketBookingSystem.Class
{
    class StandardTicket : Ticket
    {
        public string SeatNumber { get; set; }

        public StandardTicket(
            string movieName,
            decimal price,
            string seat)

            : base(movieName, price)
        {
            SeatNumber = seat;
        }


        public override decimal CalculateFinalPrice()
        {
            return PriceAfterTax;
        }


        public override void Print()
        {
            Console.WriteLine(

            $"[Ticket #{TicketId}] " +
            $"{MovieName} | Standard | " +
            $"Seat: {SeatNumber} | " +
            $"Price: {Price} | " +
            $"Final: {CalculateFinalPrice():F2} | " +
            $"Booked: {(IsBooked ? "Yes" : "No")}"

            );
        }

    }
}
