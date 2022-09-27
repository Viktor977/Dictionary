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
    public class UkrainianWordRepository :  IUkranianWordRepository
    {
        private readonly DictionaryDbContext _contex;
        public UkrainianWordRepository(DictionaryDbContext context) => _contex = context; 

        public void Create(UkranianWord ukranianWord)
        {
            _contex.Ukranians.AddRange(ukranianWord);
        }

        public void Delete(UkranianWord ukranianWord)
        {
            _contex.Ukranians.Remove(ukranianWord);
        }

        public void Update(UkranianWord ukranianWord)
        {
            _contex.Ukranians.Update(ukranianWord);
        }

        public async Task<IEnumerable<UkranianWord>> GetAllAsync()
        {
            return await _contex.Ukranians.ToListAsync();
        }

        public  async Task<UkranianWord> GetAsync(string word)
        {
            throw new NotImplementedException();
            //return await _contex.Ukranians.Include(t => t.EnglishWords)
            //     .ThenInclude(t => t.EnglishWord)
            //     .Where(t => t.Word == word).ToListAsync();
           
        }

    }
}
