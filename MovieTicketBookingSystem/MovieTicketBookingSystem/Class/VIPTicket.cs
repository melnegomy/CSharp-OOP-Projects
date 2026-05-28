using System;
using System.Collections.Generic;
using System.Text;

namespace MovieTicketBookingSystem.Class
{
    internal class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }

        public decimal ServiceFee { get; } = 50;


        public VIPTicket(
            string movieName,
            decimal price,
            bool lounge)

            : base(movieName, price)
        {
            LoungeAccess = lounge;
        }


        public override decimal CalculateFinalPrice()
        {
            return PriceAfterTax + ServiceFee;
        }


        public override void Print()
        {
            Console.WriteLine(

            $"[Ticket #{TicketId}] " +
            $"{MovieName} | VIP | " +
            $"Lounge: {(LoungeAccess ? "Yes" : "No")} | " +
            $"Fee: {ServiceFee} | " +
            $"Price: {Price} | " +
            $"Final: {CalculateFinalPrice():F2} | " +
            $"Booked: {(IsBooked ? "Yes" : "No")}"

            );
        }


    }
}
