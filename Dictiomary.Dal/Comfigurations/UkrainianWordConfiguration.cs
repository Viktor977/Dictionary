using Dictionary.Dal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dictionary.Dal.Configurations
{
    internal class UkrainianWordConfiguration : IEntityTypeConfiguration<UkranianWord>
    {
        public void Configure(EntityTypeBuilder<UkranianWord> builder)
        {
           
            builder.HasMany(t => t.EnglishWords)
                .WithOne(t => t.UkranianWord)
                .HasForeignKey(t => t.UkrId)
                .HasPrincipalKey(t => t.Id);
        }
    }
}
