using Dictionary.Dal.Access;
using Dictionary.Dal.Interfaces;
using Dictionary.Dal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Dal.Repositories
{
    public class EnglishWordRepository :  IEnglishWordRepository
    {
        private DictionaryDbContext _dictionary;
        public EnglishWordRepository(DictionaryDbContext context)=>_dictionary= context;
        
        public async Task<IEnumerable<EnglishWord>> GetAllAsync()
        {
            return await _dictionary.Englishes.ToListAsync();         
        }

        public async Task<EnglishWord>GetAsync(string word)
        {
            //return _dictionary.Set<Word>()
            //     .Include(t => t.EnglishWord)
            //     .Include(t => t.UkranianWord);
            throw new NotImplementedException();
                                                                
        }

        public void Update(EnglishWord englishWord)
        {
         _dictionary.Englishes.Update(englishWord);
        }
        public void Create(EnglishWord englisWord)
        {
            _dictionary.AddRange(englisWord);          
        }

        public void Delete(EnglishWord englishWord)
        {
            _dictionary.Englishes.RemoveRange(englishWord);          
        }
    }
}
