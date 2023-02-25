using Destinity.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace Destinity.Persistence;

public class ApplicationDbContext : DbContext {
    public DbSet<AnswerEntity> Answers => Set<AnswerEntity>();
    public DbSet<AttendeeEntity> Attendees => Set<AttendeeEntity>();
    public DbSet<EventEntity> Events => Set<EventEntity>();
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}
