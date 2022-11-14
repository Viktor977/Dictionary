using Dictionary.Bal.ModelsDto;
using Dictionary.Dal.Models;
using System.Collections.Generic;

namespace Dictionary.Bal.Interfaces
{
    public interface IUkrWordService : ICrud<UkranianWordDto>
    {
        IEnumerable<EnglishWordDto> GetEnglishWords(UkranianWordDto word);
    }  
}
