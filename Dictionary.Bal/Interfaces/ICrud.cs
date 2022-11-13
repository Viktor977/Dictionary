using System.Threading.Tasks;

namespace Dictionary.Bal.Interfaces
{
    public interface ICrud<TModel> where TModel : class
    {        
        Task Add(TModel model);
        Task Update(TModel model);
        Task Delete(TModel model);
    }
}
