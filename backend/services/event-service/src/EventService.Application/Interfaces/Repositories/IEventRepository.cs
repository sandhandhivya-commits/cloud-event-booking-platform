using EventService.Domain.Entities;
namespace EventService.Application.Interfaces.Repositories
{
    public interface IEventRepository
    {
        Task<IEnumerable<Event>> GetAllAsync();

        Task<Event?> GetByIdAsync(Guid id);

        Task<Event> AddAsync(Event entity);

        Task UpdateAsync(Event entity);

        Task DeleteAsync(Guid id);
    }
}
