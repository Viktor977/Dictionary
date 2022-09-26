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
        Task<IEnumerable<UkranianWord>> GetAllAsync();
        Task<UkranianWord>GetByIdAsync(int id);
        void DeleteUkraininWord(UkranianWord ukranianWord);
        void UpdateUkranianWord(UkranianWord ukranianWord);
        void CreateUkranianWord(UkranianWord ukranianWord);
    }
}
