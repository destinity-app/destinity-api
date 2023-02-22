using Destinity.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace Destinity.Persistence;

public class ApplicationDbContext : DbContext {
    public DbSet<AnswerEntity> Answers { get; set; }
    public DbSet<AttendeeEntity> Attendees { get; set; }
    public DbSet<EventEntity> Events { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}
