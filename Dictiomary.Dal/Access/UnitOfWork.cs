using Dictiomary.Dal.Interfaces;
using Dictiomary.Dal.Repositories;
using Dictionary.Dal.Interfaces;
using System.Threading.Tasks;

namespace Dictionary.Dal.Access
{
    public class UnitOfWork : IUnitOfWork
    {
        private DictionaryDbContext _context;
       
        private IWordRepository _wordRepository;
        public UnitOfWork(DictionaryDbContext context)
        {
            _context = context;
        }
     
        public IWordRepository WordRepository
        {
            get
            {
                if (_wordRepository == null)
                {
                    _wordRepository = new WordRepository(_context);
                }
                return _wordRepository;
            }
        }

        public async Task SaveAsync()
        {
          await _context.SaveChangesAsync();
            
        }
    }
}
