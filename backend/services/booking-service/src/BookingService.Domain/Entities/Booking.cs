using System;
using System.Collections.Generic;
using System.Text;

namespace BookingService.Domain.Entities
{
    public class Booking
    {
        public Guid Id { get; set; }

        public string EventId { get; set; }

        public string UserEmail { get; set; }

        public int TicketCount { get; set; }

        public DateTime BookingDate { get; set; }
    }
}
