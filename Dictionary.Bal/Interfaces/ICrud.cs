using Dictionary.Bal.ModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
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
