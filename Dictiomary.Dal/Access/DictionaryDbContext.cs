using Dictionary.Dal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Dal.Access
{
   public class DictionaryDbContext : DbContext
    {
        public DbSet<EnglishWord> Englishes { get; set; }
        public DbSet<UkranianWord> Ukranians { get; set; }
        public DbSet<Word> Words { get; set; }

        public DictionaryDbContext(DbContextOptions<DictionaryDbContext> options) : base(options) { }
        //public DictionaryDbContext() { }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=; Initial Catalog=WordDB; Integrated Security=SSPI;",
        //        builder=>builder.EnableRetryOnFailure());
        //}
    }
}
