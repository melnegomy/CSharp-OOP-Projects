using MovieTicketBookingSystem.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieTicketBookingSystem.Class
{
    partial class Cinema
    {
        private Ticket[] tickets =
            new Ticket[20];

        private Projector projector =
            new Projector();

        public string CinemaName { get; set; }


        public Cinema(string name)
        {
            CinemaName = name;
        }


        public void OpenCinema()
        {
            Console.WriteLine(
                "=== Cinema Opened ===");

            projector.Start();
        }


        public void CloseCinema()
        {
            projector.Stop();

            Console.WriteLine(
                "=== Cinema Closed ===");
        }


        public void AddTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return;
                }
            }
        }
    }
}
