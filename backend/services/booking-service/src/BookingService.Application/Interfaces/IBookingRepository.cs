using BookingService.Domain.Entities;

namespace BookingService.Application.Interfaces
{
    public interface IBookingRepository
    {
        Task<IEnumerable<Booking>> GetAllAsync();

        Task<Booking> GetByIdAsync(Guid id);

        Task AddAsync(Booking booking);
    }
}