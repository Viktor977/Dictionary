using Dictionary.Dal.Models;
using System;
using System.Collections.Generic;

namespace Dictionary.Dal.Interfaces
{
    public interface IEnglishWordRepository : IRepository<EnglishWord>
    {
        IEnumerable<UkranianWord> GetUkranianWords(string engWord);
    }
}
