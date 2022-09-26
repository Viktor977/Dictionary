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
    public class EnglishWordRepository : RepositoryBase<EnglishWord>, IEnglishWordRepository
    {
        public EnglishWordRepository(DictionaryDbContext context) : base(context) { }
        
        public async Task<IEnumerable<EnglishWord>> GetAllAsync()
        {
            return await GetAll().OrderBy(t => t.Id).ToListAsync();
        }

        public async Task<EnglishWord> GetByIdAsync(int id)
        {          
                return await GetByCondition(word => word.Id.Equals(id))
                    .FirstOrDefaultAsync();                    
        }

        public void UpdateEnglishWord(EnglishWord englishWord)
        {
           Update(englishWord);
        }
        public void CreateEnglisWord(EnglishWord englisWord)
        {
            Create(englisWord);
        }

        public void DeleteEnglisWord(EnglishWord englishWord)
        {
           Delete(englishWord);
        }

    }
}
