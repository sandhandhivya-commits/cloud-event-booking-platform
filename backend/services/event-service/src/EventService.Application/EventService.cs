using EventService.Application.DTOs;
using EventService.Application.Interfaces.Repositories;
using EventService.Application.Interfaces.Services;
using EventService.Domain.Entities;

namespace EventService.Application.Services;

public class EventService : IEventService
{
    private readonly IEventRepository _repository;

    public EventService(IEventRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<EventDto>> GetEventsAsync()
    {
        var events = await _repository.GetAllAsync();

        return events.Select(e => new EventDto
        {
            Id = e.Id,
            Title = e.Title,
            Description = e.Description,
            Date = e.Date,
            Location = e.Location,
            AvailableSeats = e.AvailableSeats
        });
    }

    public async Task<EventDto?> GetEventAsync(Guid id)
    {
        var e = await _repository.GetByIdAsync(id);

        if (e == null)
            return null;

        return new EventDto
        {
            Id = e.Id,
            Title = e.Title,
            Description = e.Description,
            Date = e.Date,
            Location = e.Location,
            AvailableSeats = e.AvailableSeats
        };
    }

    public async Task<EventDto> CreateEventAsync(EventDto dto)
    {
        var entity = new Event
        {
            Id = Guid.NewGuid(),
            Title = dto.Title,
            Description = dto.Description,
            Date = dto.Date,
            Location = dto.Location,
            AvailableSeats = dto.AvailableSeats
        };

        var created = await _repository.AddAsync(entity);

        dto.Id = created.Id;

        return dto;
    }

    public async Task UpdateEventAsync(EventDto dto)
    {
        var entity = new Event
        {
            Id = Guid.NewGuid(),
            Title = dto.Title,
            Description = dto.Description,
            Date = dto.Date,
            Location = dto.Location,
            AvailableSeats = dto.AvailableSeats
        };

        await _repository.UpdateAsync(entity);
    }

    public async Task DeleteEventAsync(Guid id)
    {
        await _repository.DeleteAsync(id);
    }
}