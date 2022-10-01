using Dictionary.Bal.ModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Bal.Interfaces
{
    public interface IWordService 
    {
        Task<IEnumerable<EnglishWordDto>>GetEngWords(string word);
        Task<IEnumerable<UkranianWordDto>>GetUkrWords(string word);
        Task AddWordAsync(WordDto words);
        Task UpdateAsync(WordDto words);
        Task DeleteAsync(WordDto words);
    }
}
