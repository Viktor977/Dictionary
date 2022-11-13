using Dictiomary.Dal.Interfaces;
using Dictionary.Dal.Access;
using Dictionary.Dal.Models;
using Dictionary.Dal.Repositories;


namespace Dictiomary.Dal.Repositories
{
    public class WordRepository : RepositoryBase<Word>, IWordRepository
    {      
        public WordRepository(DictionaryDbContext context):base(context) { }   
        
    }
}
