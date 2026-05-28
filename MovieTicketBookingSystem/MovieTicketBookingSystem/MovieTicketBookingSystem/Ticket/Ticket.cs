using MovieTicketBookingSystem.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieTicketBookingSystem.Class
{
    abstract class Ticket : IPrintable, IBookable
    {
        private string movieName;
        private decimal price;

        private static int counter = 0;

        public int TicketId { get; }

        public string MovieName
        {
            get { return movieName; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    movieName = value;
            }
        }

        public decimal Price
        {
            get { return price; }

            set
            {
                if (value > 0)
                    price = value;
            }
        }

        public bool IsBooked { get; private set; }


        protected Ticket(
            string movieName,
            decimal price)
        {
            MovieName = movieName;
            Price = price;

            counter++;
            TicketId = counter;
        }


        public static int GetTotalTickets()
        {
            return counter;
        }


        public virtual decimal PriceAfterTax
        {
            get
            {
                return Price + (Price * .14m);
            }
        }


        public abstract decimal CalculateFinalPrice();


        public bool Book()
        {
            if (IsBooked)
                return false;

            IsBooked = true;

            return true;
        }


        public bool Cancel()
        {
            if (!IsBooked)
                return false;

            IsBooked = false;

            return true;
        }

        public abstract void Print();
    }
}
