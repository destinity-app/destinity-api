namespace Destinity.Persistence.Entities;

public record EventEntity {
    public Guid Id { get; set; }
    public required string Name { get; set; }
}
