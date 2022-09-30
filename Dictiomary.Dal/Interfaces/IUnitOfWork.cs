using Dictiomary.Dal.Interfaces;
using System.Threading.Tasks;

namespace Dictionary.Dal.Interfaces
{
    public interface IUnitOfWork
    {  
        IWordRepository WordRepository { get; }
        Task SaveAsync();
    }
}
