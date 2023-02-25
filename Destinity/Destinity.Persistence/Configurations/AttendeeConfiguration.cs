using System.Security.Cryptography.Xml;
using Destinity.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Destinity.Persistence.Configurations; 

public class AttendeeConfiguration : IEntityTypeConfiguration<AttendeeEntity> {
    public void Configure(EntityTypeBuilder<AttendeeEntity> builder) {
        builder.HasKey(a => a.Id);
        builder
            .HasMany<AnswerEntity>()
            .WithOne(x => x.Attendee);
    }
}
