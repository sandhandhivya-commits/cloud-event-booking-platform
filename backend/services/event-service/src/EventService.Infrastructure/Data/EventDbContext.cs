using Microsoft.EntityFrameworkCore;
using EventService.Domain.Entities;

namespace EventService.Infrastructure.Data;

public class EventDbContext : DbContext
{
    public EventDbContext(DbContextOptions<EventDbContext> options)
        : base(options)
    {
    }

    public DbSet<Event> Events => Set<Event>();
}