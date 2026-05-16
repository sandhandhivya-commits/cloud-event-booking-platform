namespace BookingService.Application.DTOs
{
    public class BookingDto
    {
        public Guid Id { get; set; }

        public string EventId { get; set; }

        public string UserEmail { get; set; }

        public int TicketCount { get; set; }

        public DateTime BookingDate { get; set; }
    }
}