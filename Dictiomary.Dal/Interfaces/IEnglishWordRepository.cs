using Dictionary.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Dal.Interfaces
{
    public interface IEnglishWordRepository : IRepository<EnglishWord>
    {
        Task<IEnumerable<EnglishWord>> GetAllAsync();
        Task<EnglishWord>GetByIdAsync(int id);
        void CreateEnglisWord(EnglishWord englisWord);
        void DeleteEnglisWord(EnglishWord englishWord);
        void UpdateEnglishWord(EnglishWord englishWord);
    }
}
