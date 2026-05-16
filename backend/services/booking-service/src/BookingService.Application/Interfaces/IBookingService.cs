using BookingService.Application.DTOs;

namespace BookingService.Application.Interfaces
{
    public interface IBookingService
    {
        Task<IEnumerable<BookingDto>> GetAllBookingsAsync();

        Task<BookingDto> GetBookingByIdAsync(Guid id);

        Task<BookingDto> CreateBookingAsync(CreateBookingDto dto);
    }
}