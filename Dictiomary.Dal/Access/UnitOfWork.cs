using Dictionary.Dal.Interfaces;
using Dictionary.Dal.Repositories;
using System.Threading.Tasks;

namespace Dictionary.Dal.Access
{
    public class UnitOfWork : IUnitOfWork
    {
        private DictionaryDbContext _context;
        private IUkranianWordRepository _ukranianWordRepository;
        private IEnglishWordRepository _englishWordRepository;
        public UnitOfWork(DictionaryDbContext context)
        {
            _context = context;
        }

        public IUkranianWordRepository UkranianWordRepository
        {
            get
            {
                if (_ukranianWordRepository == null)
                {
                    _ukranianWordRepository = new UkrainianWordRepository(_context);
                }

                return _ukranianWordRepository;
            }
        }

        public IEnglishWordRepository EnglishWordRepository
        {
            get
            {
                if (_englishWordRepository == null)
                {
                    _englishWordRepository= new EnglishWordRepository(_context);
                }

                return _englishWordRepository;
            }
        }

        public async Task SaveAsync()
        {
          await _context.SaveChangesAsync();
            
        }
    }
}
