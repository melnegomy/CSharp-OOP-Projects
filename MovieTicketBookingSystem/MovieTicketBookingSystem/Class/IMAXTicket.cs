using System;
using System.Collections.Generic;
using System.Text;

namespace MovieTicketBookingSystem.Class
{
    class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }

        public IMAXTicket(
            string movieName,
            decimal price,
            bool is3D)

            : base(
                movieName,
                is3D ? price + 30 : price)
        {
            Is3D = is3D;
        }


        public override decimal CalculateFinalPrice()
        {
            return PriceAfterTax;
        }


        public override void Print()
        {
            Console.WriteLine(

            $"[Ticket #{TicketId}] " +
            $"{MovieName} | IMAX | " +
            $"3D: {(Is3D ? "Yes" : "No")} | " +
            $"Price: {Price} | " +
            $"Final: {CalculateFinalPrice():F2} | " +
            $"Booked: {(IsBooked ? "Yes" : "No")}"

            );
        }

    }
}
