using Dictionary.Bal.ModelsDto;
using Dictionary.Dal.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dictionary.Bal.Interfaces
{
    public interface IEngWordService : ICrud<EnglishWordDto> 
    {
       IEnumerable<UkranianWordDto> GetUkrWords(EnglishWordDto wordDto);
    }
}
