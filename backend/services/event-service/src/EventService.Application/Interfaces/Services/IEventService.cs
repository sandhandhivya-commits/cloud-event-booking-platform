using EventService.Application.DTOs;

namespace EventService.Application.Interfaces.Services
{
    public interface IEventService
    {
        Task<IEnumerable<EventDto>> GetEventsAsync();

        Task<EventDto?> GetEventAsync(Guid id);

        Task<EventDto> CreateEventAsync(EventDto dto);

        Task UpdateEventAsync(EventDto dto);

        Task DeleteEventAsync(Guid id);
    }
}
