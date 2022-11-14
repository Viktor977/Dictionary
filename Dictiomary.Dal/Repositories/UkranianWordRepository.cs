using Dictionary.Dal.Access;
using Dictionary.Dal.Interfaces;
using Dictionary.Dal.Models;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary.Dal.Repositories
{
    public class UkranianWordRepository : RepositoryBase<UkranianWord>,IUkranianWordRepository
    {
        private readonly DictionaryDbContext _context;
        public UkranianWordRepository(DictionaryDbContext context):base(context) => _context = context;

        public IEnumerable<EnglishWord> GetEnglishWords(string word)
        {
           var words=_context.Words.Where(t=>t.UkranianWord.Word.Contains(word))
                .Select(t=>t.EnglishWord).ToList();
            return words;
        }

        public UkranianWord GetUkranianWord(string word)
        {
           return _context.Ukranians.FirstOrDefault(t=>t.Word== word);
        }
    }
}
