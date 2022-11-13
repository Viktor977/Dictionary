using Dictionary.Dal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dictionary.Dal.Configurations
{
    internal class EnglishConfiguration : IEntityTypeConfiguration<EnglishWord>
    {
        public void Configure(EntityTypeBuilder<EnglishWord> builder)
        {
            builder.HasKey(t => t.Id);
            builder.HasMany(t => t.Words)
                .WithOne(t => t.EnglishWord)
                .HasForeignKey(t => t.EngId)
                .HasPrincipalKey(t => t.Id);
        }
    }
}
