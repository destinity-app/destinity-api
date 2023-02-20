namespace Destinity.Persistence.Entities;

public record EventEntity {
    public Guid Id { get; set; }
    public string Name { get; set; }
}
