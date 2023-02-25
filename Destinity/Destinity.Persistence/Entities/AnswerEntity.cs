namespace Destinity.Persistence.Entities;

public record AnswerEntity {
    public Guid Id { get; set; }
    public Guid AttendeeId { get; set; }
    public Status Status { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public AttendeeEntity? Attendee { get; set; }
}
