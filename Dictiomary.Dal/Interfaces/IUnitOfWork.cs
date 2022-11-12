using Dictiomary.Dal.Interfaces;
using System.Threading.Tasks;

namespace Dictionary.Dal.Interfaces
{
    public interface IUnitOfWork
    {  
        IWordRepository WordRepository { get; }
        IEnglishWordRepository EnglishWordRepository { get; }
        IUkranianWordRepository UkranianWordRepository { get; }
        Task SaveAsync();
    }
}
