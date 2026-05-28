using System;
using System.Collections.Generic;
using System.Text;

namespace MovieTicketBookingSystem.Interface
{
    internal interface IBookable
    {
        bool Book();
        bool Cancel();
    }
}
