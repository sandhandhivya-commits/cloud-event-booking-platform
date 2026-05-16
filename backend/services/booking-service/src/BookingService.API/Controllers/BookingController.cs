using BookingService.Application.DTOs;
using BookingService.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookingService.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _service;

        public BookingController(IBookingService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetBookings()
        {
            var bookings = await _service.GetAllBookingsAsync();
            return Ok(bookings);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBooking(CreateBookingDto dto)
        {
            var booking = await _service.CreateBookingAsync(dto);
            return Ok(booking);
        }
    }
}