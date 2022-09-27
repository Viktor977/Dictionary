using Dictionary.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Dal.Interfaces
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
       Task<IEnumerable<TEntity>> GetAllAsync();
       Task<TEntity> GetAsync(string word);
        void Create(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
    }
}
