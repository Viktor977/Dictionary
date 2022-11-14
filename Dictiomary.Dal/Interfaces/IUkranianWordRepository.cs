using Dictionary.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Dal.Interfaces
{
    public interface IUkranianWordRepository : IRepository<UkranianWord>
    {
        IEnumerable<EnglishWord> GetEnglishWords(string word);
        UkranianWord GetUkranianWord(string word);
    }
}
