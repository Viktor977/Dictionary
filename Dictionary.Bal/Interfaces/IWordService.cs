using Dictionary.Bal.ModelsDto;
using Dictionary.Dal.Models;
using System.Collections.Generic;

namespace Dictionary.Bal.Interfaces
{
    public interface IWordService : ICrud<WordDto>
    {
        IEnumerable<WordDto>GetEngWords(UkranianWordDto ukranianWordDto);
        IEnumerable<WordDto>GetUkrWords(EnglishWordDto englishWordDto);
       
    }
}
