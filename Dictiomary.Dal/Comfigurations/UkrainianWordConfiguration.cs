using Dictionary.Dal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dictionary.Dal.Configurations
{
    internal class UkrainianWordConfiguration : IEntityTypeConfiguration<UkranianWord>
    {
        public void Configure(EntityTypeBuilder<UkranianWord> builder)
        {
            builder.HasKey(t => t.Id);
            builder.HasMany(t => t.Words)
                .WithOne(t => t.UkranianWord)
                .HasForeignKey(t => t.UkrId)
                .HasPrincipalKey(t => t.Id);
        }
    }
}
