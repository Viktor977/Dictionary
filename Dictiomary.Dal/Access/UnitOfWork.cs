using Dictiomary.Dal.Interfaces;
using Dictiomary.Dal.Repositories;
using Dictionary.Dal.Interfaces;
using Dictionary.Dal.Repositories;
using System.Threading.Tasks;

namespace Dictionary.Dal.Access
{
    public class UnitOfWork : IUnitOfWork
    {
        private DictionaryDbContext _context;
       
        private IWordRepository _wordRepository;
        private IEnglishWordRepository _englishWordRepository;
        private IUkranianWordRepository _ukranianWordRepository;
      
        public UnitOfWork(DictionaryDbContext context) => _context = context;
         
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

        public IEnglishWordRepository EnglishWordRepository
        {
            get
            {
                if(_englishWordRepository == null)
                {
                    _englishWordRepository = new EnglishWordRepository(_context);
                }

                return _englishWordRepository;
            }
        }

        public IUkranianWordRepository UkranianWordRepository
        {
            get
            {
                if(_ukranianWordRepository== null) 
                {
                    _ukranianWordRepository = new UkranianWordRepository(_context);
                }

                return _ukranianWordRepository;
            }
        }

        public async Task SaveAsync() => await _context.SaveChangesAsync();
       
    }
}
