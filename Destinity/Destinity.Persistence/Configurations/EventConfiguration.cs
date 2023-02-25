using Destinity.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Destinity.Persistence.Configurations; 

public class EventConfiguration: IEntityTypeConfiguration<EventEntity> {
    public void Configure(EntityTypeBuilder<EventEntity> builder) {
        builder.HasKey(a => a.Id);
    }
}
