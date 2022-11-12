using Dictiomary.Dal.Interfaces;
using Dictionary.Dal.Access;
using Dictionary.Dal.Models;
using Dictionary.Dal.Repositories;


namespace Dictiomary.Dal.Repositories
{
    public class WordRepository : RepositoryBase<Word>, IWordRepository
    {
       
        public WordRepository(DictionaryDbContext context):base(context) { }   
        //public async Task AddAsync(Word entity)
        //{
        //    await _context.Englishes.AddRangeAsync(entity.EnglishWord);
        //    await _context.Ukranians.AddRangeAsync(entity.UkranianWord);
        //    await _context.Words.AddRangeAsync(entity);
        //}

        //public void Delete(Word entity)
        //{
        //     _context.Ukranians.Remove(entity.UkranianWord);
        //     _context.Englishes.Remove(entity.EnglishWord);
        //     _context.Words.Remove(entity);
           
        //}
       
        //public async Task<IEnumerable<Word>> GetAllAsync()
        //{
        //    return await _context.Words
        //         .Include(t => t.UkranianWord)
        //         .Include(t => t.EnglishWord)
        //         .ToListAsync();
        //}

        //public void Update(Word entity)
        //{
        //    _context.Englishes.Update(entity.EnglishWord);
        //    _context.Ukranians.Update(entity.UkranianWord);
        //    _context.Words.Update(entity);
        //}
    }
}
