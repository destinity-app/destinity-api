using Destinity.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Destinity.Persistence.Configurations; 

public class AnswerConfiguration: IEntityTypeConfiguration<AnswerEntity> {
    public void Configure(EntityTypeBuilder<AnswerEntity> builder) {
        builder.HasKey(a => a.Id);
    }
}
