using Dictionary.Dal.Access;
using Dictionary.Dal.Interfaces;
using Dictionary.Dal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Dal.Repositories
{
    public class UkrainianWordRepository : RepositoryBase<UkranianWord>, IUkranianWordRepository
    {
        public UkrainianWordRepository(DictionaryDbContext context) : base(context) { }

        public void CreateUkranianWord(UkranianWord ukranianWord)
        {
            Create(ukranianWord);
        }

        public void DeleteUkraininWord(UkranianWord ukranianWord)
        {
            Delete(ukranianWord);
        }

        public void UpdateUkranianWord(UkranianWord ukranianWord)
        {
            Update(ukranianWord);
        }

        public async Task<IEnumerable<UkranianWord>> GetAllAsync()
        {
            return await GetAll().OrderBy(t => t.Word).ToListAsync();
        }

        public  async Task<UkranianWord> GetByIdAsync(int id)
        {
            return await GetByCondition(word => word.Id.Equals(id)).FirstOrDefaultAsync();
        }

    }
}
