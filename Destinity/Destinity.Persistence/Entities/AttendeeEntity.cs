namespace Destinity.Persistence.Entities;

public record AttendeeEntity {
    public Guid Id { get; set; }
    public required string Nickname { get; set; }
    public ICollection<AnswerEntity> Answers { get; set; }
}
