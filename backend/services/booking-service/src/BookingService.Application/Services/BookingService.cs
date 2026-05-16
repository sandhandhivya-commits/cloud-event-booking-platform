using BookingService.Application.DTOs;
using BookingService.Application.Interfaces;
using BookingService.Domain.Entities;

namespace BookingService.Application.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _repository;

        public BookingService(IBookingRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<BookingDto>> GetAllBookingsAsync()
        {
            var bookings = await _repository.GetAllAsync();

            return bookings.Select(b => new BookingDto
            {
                Id = b.Id,
                EventId = b.EventId,
                UserEmail = b.UserEmail,
                TicketCount = b.TicketCount,
                BookingDate = b.BookingDate
            });
        }

        public async Task<BookingDto> CreateBookingAsync(CreateBookingDto dto)
        {
            var booking = new Booking
            {
                Id = Guid.NewGuid(),
                EventId = dto.EventId,
                UserEmail = dto.UserEmail,
                TicketCount = dto.TicketCount,
                BookingDate = DateTime.UtcNow
            };

            await _repository.AddAsync(booking);

            return new BookingDto
            {
                Id = booking.Id,
                EventId = booking.EventId,
                UserEmail = booking.UserEmail,
                TicketCount = booking.TicketCount,
                BookingDate = booking.BookingDate
            };
        }

        public async Task<BookingDto> GetBookingByIdAsync(Guid id)
        {
            var booking = await _repository.GetByIdAsync(id);

            if (booking == null)
                return null;

            return new BookingDto
            {
                Id = booking.Id,
                EventId = booking.EventId,
                UserEmail = booking.UserEmail,
                TicketCount = booking.TicketCount,
                BookingDate = booking.BookingDate
            };
        }
    }
}