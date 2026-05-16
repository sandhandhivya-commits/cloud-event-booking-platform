using BookingService.Application.Interfaces;
using BookingService.Domain.Entities;

namespace BookingService.Infrastructure.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private static readonly List<Booking> _bookings = new();

        public Task<IEnumerable<Booking>> GetAllAsync()
        {
            return Task.FromResult(_bookings.AsEnumerable());
        }

        public Task<Booking> GetByIdAsync(Guid id)
        {
            var booking = _bookings.FirstOrDefault(b => b.Id == id);
            return Task.FromResult(booking);
        }

        public Task AddAsync(Booking booking)
        {
            _bookings.Add(booking);
            return Task.CompletedTask;
        }
    }
}