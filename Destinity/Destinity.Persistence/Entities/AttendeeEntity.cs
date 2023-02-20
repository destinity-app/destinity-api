namespace Destinity.Persistence.Entities;

public record AttendeeEntity {
    public Guid Id { get; set; }
    public string Nick { get; set; }
}
