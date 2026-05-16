namespace BookingService.Application.DTOs
{
    public class CreateBookingDto
    {
        public string EventId { get; set; }

        public string UserEmail { get; set; }

        public int TicketCount { get; set; }
    }
}