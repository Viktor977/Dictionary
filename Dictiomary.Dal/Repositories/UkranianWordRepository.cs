using Dictionary.Dal.Access;
using Dictionary.Dal.Interfaces;
using Dictionary.Dal.Models;

namespace Dictionary.Dal.Repositories
{
    public class UkranianWordRepository : RepositoryBase<UkranianWord>,IUkranianWordRepository
    {
        public UkranianWordRepository(DictionaryDbContext context):base(context) { }
    }
}
